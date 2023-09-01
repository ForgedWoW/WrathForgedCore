﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.CodeAnalysis;
using WrathForged.Serialization.Generators;

namespace WrathForged.Serialization
{
    [Generator]
    public class SerializationGenerator : ISourceGenerator
    {
        private readonly string _attributeName = nameof(SerializablePropertyAttribute);
        private readonly string _forgedSerializableName = nameof(ForgedSerializableAttribute).Replace("Attribute", "");
        private Dictionary<string, IForgedTypeGenerator> _generatorsByName;
        private Dictionary<TypeKind, IForgedTypeGenerator> _generatorsByTypeKind;
        private Dictionary<SpecialType, IForgedTypeGenerator> _generatorsBySpecialType;
        private Dictionary<ForgedTypeCode, IForgedTypeGenerator> _generatorsByTypeCode;
        private bool _collectionSizeWritten;

        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SerializationSyntaxReceiver());

            _generatorsByTypeKind = new Dictionary<TypeKind, IForgedTypeGenerator>()
            {
                { TypeKind.Enum, new EnumTypeGenerator() },
                { TypeKind.Array, new ArrayTypeGenerator(this) }
            };

            _generatorsByName = new Dictionary<string, IForgedTypeGenerator>(StringComparer.InvariantCultureIgnoreCase)
            {
                { nameof(String), new StringGenerator() },
                { nameof(IPAddress), new IPAddressGenerator() }
            };

            _generatorsBySpecialType = new Dictionary<SpecialType, IForgedTypeGenerator>()
            {
                { SpecialType.System_Collections_Generic_IList_T, new ListTypeGenerator(this) }
            };

            _generatorsByTypeCode = new Dictionary<ForgedTypeCode, IForgedTypeGenerator>()
            {
                { ForgedTypeCode.StringParsedEnum, new StringParsedEnumGenerator() }
            };
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (!(context.SyntaxReceiver is SerializationSyntaxReceiver receiver))
                return;

            System.Diagnostics.Debugger.Launch();
            foreach (var classDeclaration in receiver.CandidateClasses)
            {
                if (!(context.Compilation.GetSemanticModel(classDeclaration.SyntaxTree).GetDeclaredSymbol(classDeclaration) is INamedTypeSymbol modelSymbol))
                    continue;

                var source = GenerateSerializationCode(context, modelSymbol);

                if (string.IsNullOrEmpty(source))
                    continue;

                context.AddSource($"{modelSymbol.Name}_Serialization", source);
            }
        }

        private string GenerateSerializationCode(GeneratorExecutionContext context, INamedTypeSymbol symbol)
        {
            _collectionSizeWritten = false;
            var properties = symbol.GetMembers()
                .OfType<IPropertySymbol>()
                .Where(prop => prop.GetAttributes().Any(attr => attr.AttributeClass.Name == _attributeName))
                .OrderBy(prop =>
                {
                    var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name == _attributeName);
                    var indexArg = attr.ConstructorArguments.First();
                    if (indexArg.Value != null)
                    {
                        return (uint)indexArg.Value;
                    }

                    return 0u;
                }).ToList();

            if (!properties.Any())
                return string.Empty;

            var sourceBuilder = new StringBuilder();
            var requiredNamespaces = new HashSet<string>();

            // Serialize and Deserialize
            BuildSerializer(context, symbol, properties, sourceBuilder);
            BuildDeserializer(context, symbol, properties, sourceBuilder, requiredNamespaces);

            // Append the namespace and class definitions
            sourceBuilder.Insert(0, $"namespace {symbol.ContainingNamespace.ToDisplayString()}" +
                "{" +
                $"    public static class {symbol.Name}SerializationExtensions" +
                "    {"
            );
            sourceBuilder.AppendLine("    }");
            sourceBuilder.AppendLine("}");

            // Append the collected required namespaces at the beginning
            // Default usings
            sourceBuilder.Insert(0, "using System;");
            sourceBuilder.Insert(0, "using System.Linq;");
            sourceBuilder.Insert(0, "using WrathForged.Serialization;");
            foreach (var ns in requiredNamespaces)
            {
                if (!string.IsNullOrEmpty(ns))
                    sourceBuilder.Insert(0, $"using {ns};\n");
            }

            return sourceBuilder.ToString();
        }

        private void BuildDeserializer(GeneratorExecutionContext context, INamedTypeSymbol symbol, List<IPropertySymbol> properties, StringBuilder sourceBuilder, HashSet<string> requiredNamespaces)
        {
            var forgedSerializableAttributeData = symbol.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name.Contains(_forgedSerializableName));

            if (forgedSerializableAttributeData != null)
            {
                var packetIdsArgument = forgedSerializableAttributeData.NamedArguments.FirstOrDefault(arg => arg.Key == "PacketIDs");
                var scopeArgument = forgedSerializableAttributeData.NamedArguments.FirstOrDefault(arg => arg.Key == "Scope");
                if (packetIdsArgument.Key != null && scopeArgument.Key != null)
                {
                    var packetIds = packetIdsArgument.Value.Values.Select(val => val.Value.ToString());
                    sourceBuilder.AppendLine($"[DeserializeDefinition(PacketScope.{(PacketScope)scopeArgument.Value.Value}, {string.Join(",", packetIds)})]");
                }
            }

            sourceBuilder.AppendLine($"public static DeserializationResult Read{symbol.Name}(this System.IO.BinaryReader reader, out {symbol.Name}? instance)");
            sourceBuilder.AppendLine("{");
            sourceBuilder.AppendLine("try");
            sourceBuilder.AppendLine("{");
            sourceBuilder.AppendLine($"instance = new {symbol.Name}();");
            sourceBuilder.AppendLine("var cachedSizes = new Dictionary<uint, int>();");

            foreach (var prop in properties)
            {
                requiredNamespaces.Add(prop?.Type?.ContainingNamespace?.ToString());
                try
                {
                    var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name == _attributeName);

                    // Check if the property has a CollectionSizeIndex attribute
                    if (attr.NamedArguments.Any(arg => arg.Key == "CollectionSizeIndex"))
                    {
                        var collectionSizeIndex = (uint)attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeIndex").Value.Value;
                        sourceBuilder.AppendLine($" cachedSizes[{collectionSizeIndex}] = reader.ReadInt32();"); // Assuming size is stored as int
                        continue;
                    }

                    var collectionType = DetermineCollectionType(prop.Type);
                    if (collectionType != CollectionType.None)
                    {
                        // Check if the property references a cached CollectionSizeIndex
                        if (attr.NamedArguments.Any(arg => arg.Key == "CollectionSizeIndex"))
                        {
                            var sizeIndexArg = (uint)attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeIndex").Value.Value;
                            sourceBuilder.AppendLine($" var collectionSize = cachedSizes[{sizeIndexArg}];");
                        }
                        else
                        {
                            var collectionSizeCode = GenerateCollectionDeserializationSizeCode(attr);
                            sourceBuilder.AppendLine(collectionSizeCode);
                        }
                    }

                    var propertyDeserializationCode = GenerateTypeDeserializationCode(context.Compilation, symbol, prop.Type, attr, prop.Name);
                    if (!string.IsNullOrEmpty(propertyDeserializationCode))
                    {
                        sourceBuilder.AppendLine(propertyDeserializationCode);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error generating deserialization code for property {prop.Name} on type {symbol.Name}", ex);
                }
            }

            sourceBuilder.AppendLine("return DeserializationResult.Success;");
            sourceBuilder.AppendLine("}");
            sourceBuilder.AppendLine("catch (EndOfStreamException)");
            sourceBuilder.AppendLine("{");
            sourceBuilder.AppendLine("instance = null;");
            sourceBuilder.AppendLine("return DeserializationResult.EndOfStream;");
            sourceBuilder.AppendLine("}");
            sourceBuilder.AppendLine("catch (Exception)");
            sourceBuilder.AppendLine("{");
            sourceBuilder.AppendLine("instance = null;");
            sourceBuilder.AppendLine("return DeserializationResult.Error;");
            sourceBuilder.AppendLine("}");
            sourceBuilder.AppendLine("}");
        }

        private void BuildSerializer(GeneratorExecutionContext context, INamedTypeSymbol symbol, List<IPropertySymbol> properties, StringBuilder sourceBuilder)
        {
            sourceBuilder.AppendLine($"public static void Serialize(this {symbol.Name} instance, System.IO.BinaryWriter writer)");
            sourceBuilder.AppendLine("{");
            sourceBuilder.AppendLine("Dictionary<uint, bool> hasDefaultValue = new Dictionary<uint, bool>();");
            foreach (var prop in properties)
            {
                var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name == _attributeName);
                // Check for the DontSerializeWhenDefaultValue attribute property
                var dontSerializeWhenDefaultValueArg = attr?.NamedArguments.FirstOrDefault(arg => arg.Key == "DontSerializeWhenDefaultValue");
                var dontSerializeWhenDefaultValue = dontSerializeWhenDefaultValueArg?.Value.Value as bool? ?? false;

                var indexArg = attr.ConstructorArguments.First();
                var dontSerializeWhenIndexIsDefaultValueArg = attr.NamedArguments.FirstOrDefault(arg => arg.Key == "DontSerializeWhenIndexIsDefaultValue");
                var dontSerializeWhenIndexIsDefaultValue = dontSerializeWhenIndexIsDefaultValueArg.Value.Value as uint? ?? uint.MaxValue;

                var index = (uint)indexArg.Value;
                sourceBuilder.AppendLine($"hasDefaultValue[{index}] = instance.{prop.Name} == default;");

                // Determine the type of the collection (Array, List, or None).
                var collectionType = DetermineCollectionType(prop.Type);

                if (collectionType != CollectionType.None)
                {
                    var collectionSizeCode = GenerateCollectionSizeCode(attr, $"instance.{prop.Name}", collectionType);
                    if (!string.IsNullOrEmpty(collectionSizeCode))
                        sourceBuilder.AppendLine(collectionSizeCode);
                }

                var propertySerializationCode = GenerateTypeSerializationCode(context.Compilation, symbol, prop.Type, attr, $"instance.{prop.Name}");

                // If DontSerializeWhenDefaultValue is set, wrap the serialization code with a check
                if (dontSerializeWhenDefaultValue)
                {
                    //var defaultValue = prop.Type.IsValueType ? Activator.CreateInstance(Type.GetType(prop.Type.ToDisplayString())).ToString() : "null";
                    propertySerializationCode = $"if(instance.{prop.Name} != default) {{ {propertySerializationCode} }}";
                }

                if (dontSerializeWhenIndexIsDefaultValue != uint.MaxValue)
                {
                    propertySerializationCode = $"if(!hasDefaultValue[{dontSerializeWhenIndexIsDefaultValue}]) {{ {propertySerializationCode} }}";
                }

                if (!string.IsNullOrEmpty(propertySerializationCode))
                {
                    sourceBuilder.AppendLine(propertySerializationCode);
                }
            }

            sourceBuilder.AppendLine("}");
        }

        internal string GenerateTypeSerializationCode(Compilation compilation, INamedTypeSymbol containerSymbol, ITypeSymbol typeSymbol, AttributeData attr, string variableName)
        {
            var forgedTypeCode = GetTypeCodeFromTypeName(typeSymbol.Name);
            var overrideTypeArg = attr?.NamedArguments.FirstOrDefault(arg => arg.Key == "OverrideType");
            if (overrideTypeArg.HasValue &&
                !string.IsNullOrEmpty(overrideTypeArg.Value.Value.ToString()) &&
                Enum.TryParse<ForgedTypeCode>(overrideTypeArg.Value.Value.ToString(), true, out var overrideCode) &&
                overrideCode != ForgedTypeCode.Empty)
            {
                forgedTypeCode = overrideCode;
            }

            // Based on the type, generate the serialization code
            if (IsPrimitiveOrSimpleType(forgedTypeCode))
            {
                return $"writer.Write({variableName});";
            }

            if (typeSymbol is IArrayTypeSymbol arrayType && arrayType.ElementType.SpecialType == SpecialType.System_Byte)
            {
                return $"if({variableName} != null){{" + $"writer.Write({variableName});}}";
            }

            if (_generatorsByTypeCode.TryGetValue(forgedTypeCode, out var forgedTypeCodeGenerator))
            {
                return forgedTypeCodeGenerator.GenerateTypeCodeSerializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
            }

            if (_generatorsByTypeKind.TryGetValue(typeSymbol.TypeKind, out var forgedTypeGenerator))
            {
                return forgedTypeGenerator.GenerateTypeCodeSerializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
            }

            if (_generatorsByName.TryGetValue(typeSymbol.Name, out var generator))
            {
                return generator.GenerateTypeCodeSerializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
            }

            if (_generatorsBySpecialType.TryGetValue(typeSymbol.SpecialType, out var specialTypeGenerator))
            {
                return specialTypeGenerator.GenerateTypeCodeSerializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
            }

            if (HasSerializeExtensionMethod(compilation, containerSymbol))
            {
                return $"{variableName}.Serialize(writer);";
            }

            return string.Empty; // Return empty if no suitable serialization method found.
        }

        internal string GenerateTypeDeserializationCode(Compilation compilation, INamedTypeSymbol containerSymbol, ITypeSymbol typeSymbol, AttributeData attr, string variableName)
        {
            try
            {
                var forgedTypeCode = GetTypeCodeFromTypeName(typeSymbol.Name);
                var overrideTypeArg = attr?.NamedArguments.FirstOrDefault(arg => arg.Key == "OverrideType");
                if (overrideTypeArg.HasValue &&
                    !string.IsNullOrEmpty(overrideTypeArg.Value.Value.ToString()) &&
                    Enum.TryParse<ForgedTypeCode>(overrideTypeArg.Value.Value.ToString(), true, out var overrideCode) &&
                    overrideCode != ForgedTypeCode.Empty)
                {
                    forgedTypeCode = overrideCode;
                }

                // Based on the type, generate the deserialization code
                if (IsPrimitiveOrSimpleType(forgedTypeCode))
                {
                    return $"instance.{variableName} = reader.Read{forgedTypeCode}();";
                }

                if (typeSymbol is IArrayTypeSymbol arrayType && arrayType.ElementType.SpecialType == SpecialType.System_Byte)
                {
                    var fixedSizeArg = 0u;

                    if (attr.NamedArguments.Any(arg => arg.Key == "FixedCollectionSize"))
                        fixedSizeArg = (uint)attr.NamedArguments.FirstOrDefault(arg => arg.Key == "FixedCollectionSize").Value.Value;

                    var sizeLengthTypeArg = string.Empty;

                    if (attr.NamedArguments.Any(arg => arg.Key == "CollectionSizeLengthType"))
                        sizeLengthTypeArg = ((TypeCode)attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeLengthType").Value.Value).ToString();

                    var sizeIndexArg = 0u;

                    if (attr.NamedArguments.Any(arg => arg.Key == "CollectionSizeIndex"))
                        sizeIndexArg = (uint)attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeIndex").Value.Value;

                    if (fixedSizeArg != 0)
                    {
                        return $"instance.{variableName} = reader.ReadBytes(collectionSize);";
                    }

                    if (!string.IsNullOrEmpty(sizeLengthTypeArg) && Enum.TryParse(sizeLengthTypeArg, out TypeCode sizeLengthType) && sizeLengthType != TypeCode.Empty)
                    {
                        return $"instance.{variableName} = reader.ReadBytes(collectionSize);";
                    }

                    if (sizeIndexArg != 0)
                    {
                        // Assuming there's a method that can jump to a specific index in the stream, read the size, and then return back to the original position, named 'GetSizeFromStreamIndex'.
                        return $"instance.{variableName} = reader.ReadBytes(GetSizeFromStreamIndex(reader, sizeIndex));";
                    }

                    return $"instance.{variableName} = reader.ReadBytes(collectionSize);";
                }

                if (_generatorsByTypeCode.TryGetValue(forgedTypeCode, out var forgedTypeCodeGenerator))
                {
                    return forgedTypeCodeGenerator.GenerateTypeCodeDeserializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
                }

                if (_generatorsByTypeKind.TryGetValue(typeSymbol.TypeKind, out var forgedTypeGenerator))
                {
                    return forgedTypeGenerator.GenerateTypeCodeDeserializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
                }

                if (_generatorsByName.TryGetValue(typeSymbol.Name, out var generator))
                {
                    return generator.GenerateTypeCodeDeserializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
                }

                if (_generatorsBySpecialType.TryGetValue(typeSymbol.SpecialType, out var specialTypeGenerator))
                {
                    return specialTypeGenerator.GenerateTypeCodeDeserializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
                }

                if (HasDeserializeExtensionMethod(compilation, containerSymbol))
                {
                    return $"instance.{variableName} = reader.Read{typeSymbol.Name}();";
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating deserialization code for type '{typeSymbol.Name}'.", ex);
            }

            return string.Empty; // Return empty if no suitable deserialization method found.
        }

        internal CollectionType DetermineCollectionType(ITypeSymbol typeSymbol)
        {
            // Check if it's an array
            if (typeSymbol is IArrayTypeSymbol)
            {
                return CollectionType.Array;
            }

            // Check if it's a list
            if (typeSymbol is INamedTypeSymbol namedTypeSymbol &&
                namedTypeSymbol.AllInterfaces.Any(i => i.OriginalDefinition.ToDisplayString() == "System.Collections.Generic.IList<T>"))
            {
                return CollectionType.List;
            }

            return CollectionType.None;
        }

        internal string GenerateCollectionSizeCode(AttributeData attribute, string variableName, CollectionType collectionType)
        {
            var fixedCollectionSize = 0u;

            if (attribute.NamedArguments.Any(arg => arg.Key == "FixedCollectionSize"))
                fixedCollectionSize = (uint)attribute.NamedArguments.FirstOrDefault(arg => arg.Key == "FixedCollectionSize").Value.Value;

            if (fixedCollectionSize != 0)
                return string.Empty;

            var lengthType = attribute.NamedArguments.FirstOrDefault(na => na.Key == "CollectionSizeLengthType").Value.Value?.ToString() ?? string.Empty;

            var sizeProperty = "Length";

            if (collectionType == CollectionType.List)
                sizeProperty = "Count";

            string lengthWriteMethod;
            string zeroWriteMethod;
            switch (lengthType)
            {
                case "Byte":
                    lengthWriteMethod = $"writer.Write((byte){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((byte)0);";
                    break;

                case "SByte":
                    lengthWriteMethod = $"writer.Write((sbyte){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((sbyte)0);";
                    break;

                case "Int16":
                    lengthWriteMethod = $"writer.Write((short){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((short)0);";
                    break;

                case "UInt16":
                    lengthWriteMethod = $"writer.Write((ushort){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((ushort)0);";
                    break;

                case "UInt32":
                    lengthWriteMethod = $"writer.Write((uint){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((uint)0);";
                    break;

                case "Int64":
                    lengthWriteMethod = $"writer.Write((long){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((long)0);";
                    break;

                case "UInt64":
                    lengthWriteMethod = $"writer.Write((ulong){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((ulong)0);";
                    break;

                default:
                    lengthWriteMethod = $"writer.Write({variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write(0);";
                    break;
            }

            return $@"
                if ({variableName} == null || {variableName}.{sizeProperty} == 0)
                {{
                    {zeroWriteMethod}
                }}
                else
                {{
                    {lengthWriteMethod}
                }}";
        }

        internal string GenerateCollectionDeserializationSizeCode(AttributeData attr)
        {
            var codeBuilder = new StringBuilder();
            var prefix = "collectionSize = ";
            if (!_collectionSizeWritten)
            {
                _collectionSizeWritten = true;
                prefix = "var collectionSize = ";
            }

            // Check for FixedCollectionSize attribute
            var fixedSizeArg = attr.NamedArguments.FirstOrDefault(arg => arg.Key == "FixedCollectionSize");
            if (fixedSizeArg.Key != null && fixedSizeArg.Value.Value != null)
            {
                var fixedSize = (uint)fixedSizeArg.Value.Value;
                codeBuilder.AppendLine($"{prefix}{fixedSize};");
                return codeBuilder.ToString();
            }

            // Check for CollectionSizeLengthType attribute
            var sizeLengthTypeArg = attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeLengthType");
            if (sizeLengthTypeArg.Key != null && sizeLengthTypeArg.Value.Value != null)
            {
                var sizeLengthType = ((TypeCode)sizeLengthTypeArg.Value.Value).ToString();
                codeBuilder.AppendLine($"{prefix}reader.Read{sizeLengthType}();");
                return codeBuilder.ToString();
            }

            // Check for CollectionSizeIndex reference
            var sizeIndexArg = attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeIndex");
            if (sizeIndexArg.Key != null && sizeIndexArg.Value.Value != null)
            {
                var collectionSizeIndex = (uint)sizeIndexArg.Value.Value;
                codeBuilder.AppendLine($"{prefix}cachedSizes[{collectionSizeIndex}];");
                return codeBuilder.ToString();
            }

            // Default case (this might be an error scenario or you can handle it differently)
            codeBuilder.AppendLine($"{prefix}reader.ReadInt32();");
            return codeBuilder.ToString();
        }

        private static ForgedTypeCode GetTypeCodeFromTypeName(string typeName)
        {
            switch (typeName)
            {
                case "string":
                case "String":
                    return ForgedTypeCode.String;

                default:
                    return Enum.TryParse(typeName, out ForgedTypeCode result) ? result : ForgedTypeCode.Empty;
            }
        }

        private bool IsPrimitiveOrSimpleType(ForgedTypeCode typeCode)
        {
            switch (typeCode)
            {
                case ForgedTypeCode.Boolean:
                case ForgedTypeCode.Byte:
                case ForgedTypeCode.Char:
                case ForgedTypeCode.Decimal:
                case ForgedTypeCode.Double:
                case ForgedTypeCode.Int16:
                case ForgedTypeCode.Int32:
                case ForgedTypeCode.Int64:
                case ForgedTypeCode.SByte:
                case ForgedTypeCode.Single:
                case ForgedTypeCode.UInt16:
                case ForgedTypeCode.UInt32:
                case ForgedTypeCode.UInt64:
                    return true;

                default:
                    return false;
            }
        }

        private bool HasSerializeExtensionMethod(Compilation compilation, INamedTypeSymbol typeSymbol)
        {
            var potentialMethods = compilation.SourceModule.GlobalNamespace
                .GetNamespaceMembers()
                .SelectMany(ns => ns.GetTypeMembers())
                .Where(t => t.IsStatic)
                .SelectMany(t => t.GetMembers().OfType<IMethodSymbol>())
                .Where(m => m.IsStatic)
                .Where(m => m.Name == "Serialize");

            foreach (var method in potentialMethods)
            {
                if (method is IMethodSymbol serializeMethod
                    && serializeMethod.Parameters.Length > 0
                    && SymbolEqualityComparer.Default.Equals(serializeMethod.Parameters[0].Type, typeSymbol))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HasDeserializeExtensionMethod(Compilation compilation, INamedTypeSymbol typeSymbol)
        {
            var potentialMethods = compilation.SourceModule.GlobalNamespace
                .GetNamespaceMembers()
                .SelectMany(ns => ns.GetTypeMembers())
                .Where(t => t.IsStatic)
                .SelectMany(t => t.GetMembers().OfType<IMethodSymbol>())
                .Where(m => m.IsStatic)
                .Where(m => m.Name == $"Read{typeSymbol.Name}");

            foreach (var method in potentialMethods)
            {
                if (method is IMethodSymbol serializeMethod
                    && serializeMethod.Parameters.Length > 0
                    && SymbolEqualityComparer.Default.Equals(serializeMethod.Parameters[0].Type, typeSymbol))
                {
                    return true;
                }
            }

            return false;
        }
    }
}