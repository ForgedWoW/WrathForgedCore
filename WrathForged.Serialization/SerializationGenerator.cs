// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using WrathForged.Serialization.Generators;

namespace WrathForged.Serialization
{
    [Generator]
    public class SerializationGenerator : ISourceGenerator
    {
        private readonly string _attributeName = nameof(SerializablePropertyAttribute);

        private Dictionary<string, IForgedTypeGenerator> _generatorsByName;
        private Dictionary<TypeKind, IForgedTypeGenerator> _generatorsByTypeKind;
        private Dictionary<SpecialType, IForgedTypeGenerator> _generatorsBySpecialType;

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
                { nameof(String), new StringGenerator() }
            };

            _generatorsBySpecialType = new Dictionary<SpecialType, IForgedTypeGenerator>()
            {
                { SpecialType.System_Collections_Generic_IList_T, new ListTypeGenerator(this) }
            };
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (!(context.SyntaxReceiver is SerializationSyntaxReceiver receiver))
                return;

            foreach (var classDeclaration in receiver.CandidateClasses)
            {
                var modelSymbol = context.Compilation.GetSemanticModel(classDeclaration.SyntaxTree).GetDeclaredSymbol(classDeclaration) as INamedTypeSymbol;

                if (modelSymbol == null)
                    continue;

                var source = GenerateSerializationCode(context, modelSymbol);

                if (string.IsNullOrEmpty(source))
                    continue;

                context.AddSource($"{modelSymbol.Name}_Serialization", source);
            }
        }

        private string GenerateSerializationCode(GeneratorExecutionContext context, INamedTypeSymbol symbol)
        {
            //System.Diagnostics.Debugger.Launch();
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
            sourceBuilder.AppendLine("using System;");
            sourceBuilder.AppendLine("using WrathForged.Serialization;");
            sourceBuilder.AppendLine($"namespace {symbol.ContainingNamespace.ToDisplayString()}");
            sourceBuilder.AppendLine("{");
            sourceBuilder.AppendLine($"    public static class {symbol.Name}SerializationExtensions");
            sourceBuilder.AppendLine("    {");
            BuildSerializer(context, symbol, properties, sourceBuilder);
            BuildDeserializer(context, symbol, properties, sourceBuilder);
            return sourceBuilder.ToString();
        }

        private void BuildDeserializer(GeneratorExecutionContext context, INamedTypeSymbol symbol, List<IPropertySymbol> properties, StringBuilder sourceBuilder)
        {
            sourceBuilder.AppendLine($"        public static {symbol.Name} Deserialize(System.IO.BinaryReader reader)");
            sourceBuilder.AppendLine("        {");
            sourceBuilder.AppendLine($"            var instance = new {symbol.Name}();");

            foreach (var prop in properties)
            {
                var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name == _attributeName);

                var collectionType = DetermineCollectionType(prop.Type);
                if (collectionType != CollectionType.None)
                {
                    var collectionSizeCode = GenerateCollectionDeserializationSizeCode(attr);
                    sourceBuilder.AppendLine(collectionSizeCode);
                }

                var propertyDeserializationCode = GenerateTypeDeserializationCode(context.Compilation, symbol, prop.Type, attr, prop.Name);
                if (!string.IsNullOrEmpty(propertyDeserializationCode))
                {
                    sourceBuilder.AppendLine($"            instance.{prop.Name} = {propertyDeserializationCode}");
                }
            }

            sourceBuilder.AppendLine("            return instance;");
            sourceBuilder.AppendLine("        }");
        }

        private void BuildSerializer(GeneratorExecutionContext context, INamedTypeSymbol symbol, List<IPropertySymbol> properties, StringBuilder sourceBuilder)
        {
            sourceBuilder.AppendLine($"        public static void Serialize(this {symbol.Name} instance, System.IO.BinaryWriter writer)");
            sourceBuilder.AppendLine("        {");

            foreach (var prop in properties)
            {
                var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name == _attributeName);

                // Determine the type of the collection (Array, List, or None).
                var collectionType = DetermineCollectionType(prop.Type);

                if (collectionType != CollectionType.None)
                {
                    var collectionSizeCode = GenerateCollectionSizeCode(attr, $"instance.{prop.Name}", collectionType);
                    sourceBuilder.AppendLine(collectionSizeCode);
                }

                var propertySerializationCode = GenerateTypeSerializationCode(context.Compilation, symbol, prop.Type, attr, $"instance.{prop.Name}");
                if (!string.IsNullOrEmpty(propertySerializationCode))
                {
                    sourceBuilder.AppendLine(propertySerializationCode);
                }
            }

            sourceBuilder.AppendLine("        }");
            sourceBuilder.AppendLine("    }");
            sourceBuilder.AppendLine("}");
        }

        // Needed for arrays/lists
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
            if (IsPrimitiveOrSimpleType(forgedTypeCode) || typeSymbol is IArrayTypeSymbol arrayType && arrayType.ElementType.SpecialType == SpecialType.System_Byte)
            {
                return $"writer.Write({variableName});";
            }
            else if (_generatorsByTypeKind.TryGetValue(typeSymbol.TypeKind, out var forgedTypeGenerator))
            {
                return forgedTypeGenerator.GenerateTypeCodeSerializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
            }
            else if (_generatorsByName.TryGetValue(typeSymbol.Name, out var generator))
            {
                return generator.GenerateTypeCodeSerializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
            }
            else if (_generatorsBySpecialType.TryGetValue(typeSymbol.SpecialType, out var specialTypeGenerator))
            {
                return specialTypeGenerator.GenerateTypeCodeSerializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol, variableName);
            }
            else if (HasSerializeExtensionMethod(compilation, containerSymbol))
            {
                return $"{variableName}.Serialize(writer);";
            }

            return string.Empty; // Return empty if no suitable serialization method found.
        }

        internal string GenerateTypeDeserializationCode(Compilation compilation, INamedTypeSymbol containerSymbol, ITypeSymbol typeSymbol, AttributeData attr, string variableName)
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
                return $"{variableName} = reader.Read{forgedTypeCode}();";
            }
            else if (typeSymbol is IArrayTypeSymbol arrayType && arrayType.ElementType.SpecialType == SpecialType.System_Byte)
            {
                var fixedSizeArg = (uint)attr.NamedArguments.FirstOrDefault(arg => arg.Key == "FixedCollectionSize").Value.Value;
                var sizeLengthTypeArg = attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeLengthType").Value.Value.ToString();
                var sizeIndexArg = (uint)attr.NamedArguments.FirstOrDefault(arg => arg.Key == "CollectionSizeIndex").Value.Value;

                if (fixedSizeArg != 0)
                {
                    return $"{variableName} = reader.ReadBytes({fixedSizeArg});";
                }
                else if (!string.IsNullOrEmpty(sizeLengthTypeArg) && Enum.TryParse(sizeLengthTypeArg, out TypeCode sizeLengthType) && sizeLengthType != TypeCode.Empty)
                {
                    return $"{variableName} = reader.ReadBytes(reader.Read{sizeLengthTypeArg}());";
                }
                else if (sizeIndexArg != 0)
                {
                    // Assuming there's a method that can jump to a specific index in the stream, read the size, and then return back to the original position, named 'GetSizeFromStreamIndex'.
                    return $"{variableName} = reader.ReadBytes(GetSizeFromStreamIndex(reader, sizeIndex));";
                }
                else
                {
                    throw new InvalidOperationException($"Unable to determine the size for deserializing byte array for {variableName}.");
                }
            }
            else if (_generatorsByTypeKind.TryGetValue(typeSymbol.TypeKind, out var forgedTypeGenerator))
            {
                return forgedTypeGenerator.GenerateTypeCodeDeserializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol);
            }
            else if (_generatorsByName.TryGetValue(typeSymbol.Name, out var generator))
            {
                return generator.GenerateTypeCodeDeserializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol);
            }
            else if (_generatorsBySpecialType.TryGetValue(typeSymbol.SpecialType, out var specialTypeGenerator))
            {
                return specialTypeGenerator.GenerateTypeCodeDeserializeForType(typeSymbol, attr, forgedTypeCode, compilation, containerSymbol);
            }
            else if (HasDeserializeExtensionMethod(compilation, containerSymbol))
            {
                return $"{variableName} = {typeSymbol.Name}.Deserialize(reader);";
            }

            return string.Empty; // Return empty if no suitable deserialization method found.
        }

        internal CollectionType DetermineCollectionType(ITypeSymbol typeSymbol)
        {
            if (typeSymbol.SpecialType == SpecialType.System_Array)
            {
                return CollectionType.Array;
            }

            if (typeSymbol is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.AllInterfaces.Any(i => i.OriginalDefinition.SpecialType == SpecialType.System_Collections_Generic_IList_T))
            {
                return CollectionType.List;
            }

            return CollectionType.None;
        }

        internal string GenerateCollectionSizeCode(AttributeData attribute, string variableName, CollectionType collectionType)
        {
            var fixedCollectionSize = (uint)attribute.NamedArguments.FirstOrDefault(na => na.Key == "FixedCollectionSize").Value.Value;

            if (fixedCollectionSize != 0)
                return string.Empty;

            var lengthType = attribute.NamedArguments.FirstOrDefault(na => na.Key == "CollectionSizeLengthType").Value.Value?.ToString() ?? "Empty";

            string lengthWriteMethod;
            string zeroWriteMethod;
            switch (lengthType)
            {
                case "Byte":
                    lengthWriteMethod = $"writer.Write((byte){variableName}.Count);";
                    zeroWriteMethod = "writer.Write((byte)0);";
                    break;

                case "SByte":
                    lengthWriteMethod = $"writer.Write((sbyte){variableName}.Count);";
                    zeroWriteMethod = "writer.Write((sbyte)0);";
                    break;

                case "Int16":
                    lengthWriteMethod = $"writer.Write((short){variableName}.Count);";
                    zeroWriteMethod = "writer.Write((short)0);";
                    break;

                case "UInt16":
                    lengthWriteMethod = $"writer.Write((ushort){variableName}.Count);";
                    zeroWriteMethod = "writer.Write((ushort)0);";
                    break;

                case "UInt32":
                    lengthWriteMethod = $"writer.Write((uint){variableName}.Count);";
                    zeroWriteMethod = "writer.Write((uint)0);";
                    break;

                case "Int64":
                    lengthWriteMethod = $"writer.Write((long){variableName}.Count);";
                    zeroWriteMethod = "writer.Write((long)0);";
                    break;

                case "UInt64":
                    lengthWriteMethod = $"writer.Write((ulong){variableName}.Count);";
                    zeroWriteMethod = "writer.Write((ulong)0);";
                    break;

                default:
                    lengthWriteMethod = $"writer.Write({variableName}.Count);";
                    zeroWriteMethod = "writer.Write(0);";
                    break;
            }

            if (collectionType == CollectionType.Array)
            {
                lengthWriteMethod = lengthWriteMethod.Replace(".Count", ".Length");
            }

            return $@"
                if ({variableName} == null || {variableName}.Count == 0)
                {{
                    {zeroWriteMethod}
                }}
                else
                {{
                    {lengthWriteMethod}
                }}";
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
                .Where(m => m.Name == "Deserialize");

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