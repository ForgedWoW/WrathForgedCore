﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Net;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using WrathForged.Serialization.Generators;
using WrathForged.Serialization.Models;

namespace WrathForged.Serialization
{
    [Generator]
    public class SerializationGenerator : ISourceGenerator
    {
        private readonly string _attributeName = nameof(SerializablePropertyAttribute);
        private readonly string _forgedSerializableName = nameof(ForgedSerializableAttribute).Replace("Attribute", "");
        private readonly Dictionary<string, IForgedTypeGenerator> _generatorsByName = new(StringComparer.InvariantCultureIgnoreCase);
        private readonly Dictionary<TypeKind, IForgedTypeGenerator> _generatorsByTypeKind = new();
        private readonly Dictionary<SpecialType, IForgedTypeGenerator> _generatorsBySpecialType = new();
        private readonly Dictionary<ForgedTypeCode, IForgedTypeGenerator> _generatorsByTypeCode = new();
        private bool _collectionSizeWritten;

        public void Initialize(GeneratorInitializationContext context)
        {
            //System.Diagnostics.Debugger.Launch();
            context.RegisterForSyntaxNotifications(() => new SerializationSyntaxReceiver());

            _generatorsByTypeKind.Add(TypeKind.Enum, new EnumTypeGenerator());
            _generatorsByTypeKind.Add(TypeKind.Array, new ArrayTypeGenerator(this));

            _generatorsByName.Add(nameof(IPAddress), new IPAddressGenerator());
            _generatorsByName.Add(nameof(String), new StringGenerator());

            _generatorsBySpecialType.Add(SpecialType.System_Collections_Generic_IList_T, new ListTypeGenerator(this));
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (context.SyntaxReceiver is not SerializationSyntaxReceiver receiver)
                return;

            //System.Diagnostics.Debugger.Launch();
            foreach (var classDeclaration in receiver.CandidateClasses)
            {
                if (context.Compilation.GetSemanticModel(classDeclaration.SyntaxTree).GetDeclaredSymbol(classDeclaration) is not INamedTypeSymbol modelSymbol)
                    continue;

                var source = GenerateSerializationCode(context, modelSymbol, "class");

                if (string.IsNullOrEmpty(source))
                    continue;
#if DEBUG
                System.Diagnostics.Debug.WriteLine(source);
#endif
                context.AddSource($"{modelSymbol.Name}", SourceText.From(source));
            }

            foreach (var classDeclaration in receiver.CandidateRecords)
            {
                if (context.Compilation.GetSemanticModel(classDeclaration.SyntaxTree).GetDeclaredSymbol(classDeclaration) is not INamedTypeSymbol modelSymbol)
                    continue;

                var source = GenerateSerializationCode(context, modelSymbol, "record");

                if (string.IsNullOrEmpty(source))
                    continue;
#if DEBUG
                System.Diagnostics.Debug.WriteLine(source);
#endif
                context.AddSource($"{modelSymbol.Name}", SourceText.From(source, Encoding.UTF8));
            }
        }

        private string GenerateSerializationCode(GeneratorExecutionContext context, INamedTypeSymbol symbol, string classOrRecord)
        {
            _collectionSizeWritten = false;
            var properties = symbol.GetMembers()
                .OfType<IPropertySymbol>()
                .Where(prop => prop.GetAttributes().Any(attr => attr.AttributeClass?.Name == _attributeName))
                .OrderBy(prop =>
                {
                    var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass?.Name == _attributeName);
                    var indexArg = attr?.ConstructorArguments.First();
                    return indexArg.HasValue && indexArg.Value.Value != null ? (uint)indexArg.Value.Value : 0u;
                }).ToList();

            if (!properties.Any())
                return string.Empty;

            var sourceBuilder = new StringBuilder();
            var requiredNamespaces = new HashSet<string>();

            _ = sourceBuilder.AppendLine("");
            _ = sourceBuilder.AppendLine("#pragma warning disable CS8602");
            _ = sourceBuilder.AppendLine("#pragma warning disable CS8604");
            _ = sourceBuilder.AppendLine("");
            // Serialize and Deserialize
            BuildSerializer(context, symbol, properties, sourceBuilder);
            BuildDeserializer(context, symbol, properties, sourceBuilder, requiredNamespaces);

            // Append the namespace and class definitions
            _ = sourceBuilder.Insert(0, $"namespace {symbol.ContainingNamespace.ToDisplayString()}" +
                " {\r\n" +
                $"    public partial {classOrRecord} {symbol.Name}\r\n" +
                "    {\r\n"
            );
            _ = sourceBuilder.AppendLine("    }");
            _ = sourceBuilder.AppendLine("}");

            // Append the collected required namespaces at the beginning Default usings
            _ = sourceBuilder.Insert(0, "using System;\r\n");
            _ = sourceBuilder.Insert(0, "using System.Linq;\r\n");
            _ = sourceBuilder.Insert(0, "using WrathForged.Serialization;\r\n");
            foreach (var ns in requiredNamespaces)
            {
                if (!string.IsNullOrEmpty(ns))
                    _ = sourceBuilder.Insert(0, $"using {ns};\r\n");
            }

            return sourceBuilder.ToString();
        }

        private void BuildDeserializer(GeneratorExecutionContext context, INamedTypeSymbol symbol, List<IPropertySymbol> properties, StringBuilder sourceBuilder, HashSet<string> requiredNamespaces)
        {
            var forgedSerializableAttributeData = symbol.GetAttributes().FirstOrDefault(a => a.AttributeClass != null && a.AttributeClass.Name.Contains(_forgedSerializableName));

            if (forgedSerializableAttributeData != null)
            {
                var packetIdsArgument = forgedSerializableAttributeData.NamedArguments.FirstOrDefault(arg => arg.Key == "PacketIDs");
                var scopeArgument = forgedSerializableAttributeData.NamedArguments.FirstOrDefault(arg => arg.Key == "Scope");
                if (packetIdsArgument.Key != null && scopeArgument.Key != null && scopeArgument.Value.Value != null)
                {
                    var packetIds = packetIdsArgument.Value.Values.Where(val => val.Value != null).Select(val => val.Value?.ToString());
                    _ = sourceBuilder.AppendLine($"[DeserializeDefinition(PacketScope.{(PacketScope)scopeArgument.Value.Value}, {string.Join(",", packetIds)})]");
                }
            }

            _ = sourceBuilder.AppendLine($"public DeserializationResult Read(System.IO.BinaryReader reader)");
            _ = sourceBuilder.AppendLine("{");
            _ = sourceBuilder.AppendLine("try");
            _ = sourceBuilder.AppendLine("{");
            _ = sourceBuilder.AppendLine("var cachedSizes = new Dictionary<uint, int>();");

            foreach (var prop in properties)
            {
                var ns = prop.Type.ContainingNamespace?.ToString();

                if (ns != null && !string.IsNullOrEmpty(ns) && ns != "System" && ns != "System.Collections.Generic")
                    _ = requiredNamespaces.Add(ns);

                try
                {
                    var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass?.Name == _attributeName);

                    if (attr == null)
                        continue;

                    // Check if the property has a CollectionSizeIndex attribute
                    if (attr.HasNamedArg("CollectionSizeIndex"))
                    {
                        var collectionSizeIndex = attr.GetNamedArg<uint>("CollectionSizeIndex", 0);
                        _ = sourceBuilder.AppendLine($" cachedSizes[{collectionSizeIndex}] = reader.ReadInt32();"); // Assuming size is stored as int
                        continue;
                    }

                    var collectionType = DetermineCollectionType(prop.Type);
                    if (collectionType != CollectionType.None)
                    {
                        // Check if the property references a cached CollectionSizeIndex
                        if (attr.HasNamedArg("CollectionSizeIndex"))
                        {
                            var sizeIndexArg = attr.GetNamedArg<uint>("CollectionSizeIndex", 0);
                            _ = sourceBuilder.AppendLine($" var collectionSize = cachedSizes[{sizeIndexArg}];");
                        }
                        else
                        {
                            var collectionSizeCode = GenerateCollectionDeserializationSizeCode(attr);
                            _ = sourceBuilder.AppendLine(collectionSizeCode);
                        }
                    }

                    var propertyDeserializationCode = GenerateTypeDeserializationCode(context.Compilation, symbol, prop.Type, attr, prop.Name);
                    if (!string.IsNullOrEmpty(propertyDeserializationCode))
                    {
                        _ = sourceBuilder.AppendLine(propertyDeserializationCode);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error generating deserialization code for property {prop.Name} on type {symbol.Name}", ex);
                }
            }

            _ = sourceBuilder.AppendLine("return DeserializationResult.Success;");
            _ = sourceBuilder.AppendLine("}");
            _ = sourceBuilder.AppendLine("catch (EndOfStreamException)");
            _ = sourceBuilder.AppendLine("{");
            _ = sourceBuilder.AppendLine("return DeserializationResult.EndOfStream;");
            _ = sourceBuilder.AppendLine("}");
            _ = sourceBuilder.AppendLine("catch (Exception)");
            _ = sourceBuilder.AppendLine("{");
            _ = sourceBuilder.AppendLine("return DeserializationResult.Error;");
            _ = sourceBuilder.AppendLine("}");
            _ = sourceBuilder.AppendLine("}");
        }

        private void BuildSerializer(GeneratorExecutionContext context, INamedTypeSymbol symbol, List<IPropertySymbol> properties, StringBuilder sourceBuilder)
        {
            _ = sourceBuilder.AppendLine($"public void Serialize(System.IO.BinaryWriter writer)");
            _ = sourceBuilder.AppendLine("{");
            _ = sourceBuilder.AppendLine("Dictionary<uint, bool> hasDefaultValue = new Dictionary<uint, bool>();");
            foreach (var prop in properties)
            {
                var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass?.Name == _attributeName);

                if (attr == null)
                    continue;

                // Check for the DontSerializeWhenDefaultValue attribute property
                var dontSerializeWhenDefaultValue = attr.GetNamedArg("DontSerializeWhenDefaultValue", false);

                var indexArg = attr.ConstructorArguments.FirstOrDefault();
                var dontSerializeWhenIndexIsDefaultValue = attr.GetNamedArg("DontSerializeWhenIndexIsDefaultValue", uint.MaxValue);

                var index = indexArg.Value != null ? (uint)indexArg.Value : 0;
                _ = sourceBuilder.AppendLine($"hasDefaultValue[{index}] = {prop.Name} == default;");

                // Determine the type of the collection (Array, List, or None).
                var collectionType = DetermineCollectionType(prop.Type);

                if (collectionType != CollectionType.None)
                {
                    var collectionSizeCode = GenerateCollectionSizeCode(attr, $"{prop.Name}", collectionType);
                    if (!string.IsNullOrEmpty(collectionSizeCode))
                        _ = sourceBuilder.AppendLine(collectionSizeCode);
                }

                var propertySerializationCode = GenerateTypeSerializationCode(context.Compilation, symbol, prop.Type, attr, $"{prop.Name}");

                // If DontSerializeWhenDefaultValue is set, wrap the serialization code with a check
                if (dontSerializeWhenDefaultValue)
                {
                    //var defaultValue = prop.Type.IsValueType ? Activator.CreateInstance(Type.GetType(prop.Type.ToDisplayString())).ToString() : "null";
                    propertySerializationCode = $"if({prop.Name} != default) {{ {propertySerializationCode} }}";
                }

                if (dontSerializeWhenIndexIsDefaultValue != uint.MaxValue)
                {
                    propertySerializationCode = $"if(!hasDefaultValue[{dontSerializeWhenIndexIsDefaultValue}]) {{ {propertySerializationCode} }}";
                }

                if (!string.IsNullOrEmpty(propertySerializationCode))
                {
                    _ = sourceBuilder.AppendLine(propertySerializationCode);
                }
            }

            _ = sourceBuilder.AppendLine("}");
        }

        internal string GenerateTypeSerializationCode(Compilation compilation, INamedTypeSymbol containerSymbol, ITypeSymbol typeSymbol, AttributeData attr, string variableName)
        {
            var forgedTypeCode = GetTypeCodeFromTypeName(typeSymbol.Name);
            var overrideCode = attr.GetNamedArg("OverrideType", ForgedTypeCode.Empty);
            if (overrideCode != ForgedTypeCode.Empty)
                forgedTypeCode = overrideCode;

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

            if (typeSymbol.GetAttributes().Any(a => a.AttributeClass?.Name == _forgedSerializableName))
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
                var overrideCode = attr.GetNamedArg("OverrideType", ForgedTypeCode.Empty);
                if (overrideCode != ForgedTypeCode.Empty)
                    forgedTypeCode = overrideCode;

                // Based on the type, generate the deserialization code
                if (IsPrimitiveOrSimpleType(forgedTypeCode))
                {
                    return $"{variableName} = reader.Read{forgedTypeCode}();";
                }

                if (typeSymbol is IArrayTypeSymbol arrayType && arrayType.ElementType.SpecialType == SpecialType.System_Byte)
                {
                    var fixedSizeArg = 0u;

                    if (attr.HasNamedArg("FixedCollectionSize"))
                        fixedSizeArg = attr.GetNamedArg("FixedCollectionSize", 0u);

                    var sizeLengthTypeArg = string.Empty;

                    if (attr.HasNamedArg("CollectionSizeLengthType"))
                        sizeLengthTypeArg = ((TypeCode)attr.GetNamedArg("CollectionSizeLengthType", 0)).ToString();

                    var sizeIndexArg = 0u;

                    if (attr.HasNamedArg("CollectionSizeIndex"))
                        sizeIndexArg = attr.GetNamedArg("CollectionSizeIndex", 0u);

                    if (fixedSizeArg != 0)
                    {
                        return $"{variableName} = reader.ReadBytes(collectionSize);";
                    }

                    if (!string.IsNullOrEmpty(sizeLengthTypeArg) && Enum.TryParse(sizeLengthTypeArg, out TypeCode sizeLengthType) && sizeLengthType != TypeCode.Empty)
                    {
                        return $"{variableName} = reader.ReadBytes(collectionSize);";
                    }

                    if (sizeIndexArg != 0)
                    {
                        // Assuming there's a method that can jump to a specific index in the
                        // stream, read the size, and then return back to the original position,
                        // named 'GetSizeFromStreamIndex'.
                        return $"{variableName} = reader.ReadBytes(GetSizeFromStreamIndex(reader, sizeIndex));";
                    }

                    return $"{variableName} = reader.ReadBytes(collectionSize);";
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

                if (typeSymbol.GetAttributes().Any(a => a.AttributeClass?.Name == _forgedSerializableName))
                {
                    return $"{variableName} = reader.Read{typeSymbol.Name}();";
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating deserialization code for type '{typeSymbol.Name}'.", ex);
            }

            return string.Empty; // Return empty if no suitable deserialization method found.
        }

        internal static CollectionType DetermineCollectionType(ITypeSymbol typeSymbol)
        {
            // Check if it's an array
            if (typeSymbol is IArrayTypeSymbol)
            {
                return CollectionType.Array;
            }

            // Check if it's a list
            return typeSymbol is INamedTypeSymbol namedTypeSymbol &&
                namedTypeSymbol.AllInterfaces.Any(i => i.OriginalDefinition.ToDisplayString() == "System.Collections.Generic.IList<T>")
                ? CollectionType.List
                : CollectionType.None;
        }

        internal static string GenerateCollectionSizeCode(AttributeData attribute, string variableName, CollectionType collectionType)
        {
            var fixedCollectionSize = attribute.GetNamedArg("FixedCollectionSize", 0u);

            if (fixedCollectionSize != 0)
                return string.Empty;

            var lengthType = attribute.GetNamedArg("CollectionSizeLengthType", TypeCode.Empty);

            var sizeProperty = "Length";

            if (collectionType == CollectionType.List)
                sizeProperty = "Count";

            string lengthWriteMethod;
            string zeroWriteMethod;
            switch (lengthType)
            {
                case TypeCode.Byte:
                    lengthWriteMethod = $"writer.Write((byte){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((byte)0);";
                    break;

                case TypeCode.SByte:
                    lengthWriteMethod = $"writer.Write((sbyte){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((sbyte)0);";
                    break;

                case TypeCode.Int16:
                    lengthWriteMethod = $"writer.Write((short){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((short)0);";
                    break;

                case TypeCode.UInt16:
                    lengthWriteMethod = $"writer.Write((ushort){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((ushort)0);";
                    break;

                case TypeCode.UInt32:
                    lengthWriteMethod = $"writer.Write((uint){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((uint)0);";
                    break;

                case TypeCode.Int64:
                    lengthWriteMethod = $"writer.Write((long){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((long)0);";
                    break;

                case TypeCode.UInt64:
                    lengthWriteMethod = $"writer.Write((ulong){variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write((ulong)0);";
                    break;

                default:
                    lengthWriteMethod = $"writer.Write({variableName}.{sizeProperty});";
                    zeroWriteMethod = "writer.Write(0);";
                    break;
            }

            return $@"
                if ({variableName} == null || {variableName}.{sizeProperty} == 0) {{ {zeroWriteMethod} }} else {{ {lengthWriteMethod} }}";
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
                _ = codeBuilder.AppendLine($"{prefix}{fixedSize};");
                return codeBuilder.ToString();
            }

            // Check for CollectionSizeLengthType attribute
            var sizeLengthTypeArg = attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeLengthType");
            if (sizeLengthTypeArg.Key != null && sizeLengthTypeArg.Value.Value != null)
            {
                var sizeLengthType = ((TypeCode)sizeLengthTypeArg.Value.Value).ToString();
                _ = codeBuilder.AppendLine($"{prefix}reader.Read{sizeLengthType}();");
                return codeBuilder.ToString();
            }

            // Check for CollectionSizeIndex reference
            var sizeIndexArg = attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeIndex");
            if (sizeIndexArg.Key != null && sizeIndexArg.Value.Value != null)
            {
                var collectionSizeIndex = (uint)sizeIndexArg.Value.Value;
                _ = codeBuilder.AppendLine($"{prefix}cachedSizes[{collectionSizeIndex}];");
                return codeBuilder.ToString();
            }

            // Default case (this might be an error scenario or you can handle it differently)
            _ = codeBuilder.AppendLine($"{prefix}reader.ReadInt32();");
            return codeBuilder.ToString();
        }

        private static ForgedTypeCode GetTypeCodeFromTypeName(string typeName)
        {
            return typeName switch
            {
                "string" or "String" => ForgedTypeCode.String,
                _ => Enum.TryParse(typeName, out ForgedTypeCode result) ? result : ForgedTypeCode.Empty,
            };
        }

        private static bool IsPrimitiveOrSimpleType(ForgedTypeCode typeCode)
        {
            return typeCode switch
            {
                ForgedTypeCode.Boolean or ForgedTypeCode.Byte or ForgedTypeCode.Char or ForgedTypeCode.Decimal or ForgedTypeCode.Double or ForgedTypeCode.Int16 or ForgedTypeCode.Int32 or ForgedTypeCode.Int64 or ForgedTypeCode.SByte or ForgedTypeCode.Single or ForgedTypeCode.UInt16 or ForgedTypeCode.UInt32 or ForgedTypeCode.UInt64 => true,
                _ => false,
            };
        }
    }
}