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
            sourceBuilder.AppendLine($"        public static void Serialize(this {symbol.Name} instance, System.IO.BinaryWriter writer)");
            sourceBuilder.AppendLine("        {");

            foreach (var prop in properties)
            {
                var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name == _attributeName);
                var propertySerializationCode = GenerateTypeSerializationCode(context.Compilation, symbol, prop.Type, attr, $"instance.{prop.Name}");
                if (!string.IsNullOrEmpty(propertySerializationCode))
                {
                    sourceBuilder.AppendLine(propertySerializationCode);
                }
            }

            sourceBuilder.AppendLine("        }");
            sourceBuilder.AppendLine("    }");
            sourceBuilder.AppendLine("}");

            return sourceBuilder.ToString();
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
            if (IsPrimitiveOrSimpleType(forgedTypeCode))
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
    }
}