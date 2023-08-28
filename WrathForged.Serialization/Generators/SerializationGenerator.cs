using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    [Generator]
    public class SerializationGenerator : ISourceGenerator
    {
        private readonly string _attributeName = nameof(SerializablePropertyAttribute);
        private readonly Dictionary<string, IForgedTypeGenerator> _generators = new Dictionary<string, IForgedTypeGenerator>(StringComparer.InvariantCultureIgnoreCase)
        {
            { nameof(String), new StringGenerator() }
        };

        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SerializationSyntaxReceiver());
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

            StringBuilder sourceBuilder = new StringBuilder();
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
                var forgedTypeCode = GetTypeCodeFromTypeName(prop.Type.Name);
                var attr = prop.GetAttributes().FirstOrDefault(a => a.AttributeClass.Name == _attributeName);

                // Get the override type
                var overrideTypeArg = attr?.NamedArguments.FirstOrDefault(arg => arg.Key == "OverrideType");

                if (overrideTypeArg.HasValue &&
                    !string.IsNullOrEmpty(overrideTypeArg.Value.Value.ToString()) &&
                    Enum.TryParse<ForgedTypeCode>(overrideTypeArg.Value.Value.ToString(), true, out var overrideCode) &&
                    overrideCode != ForgedTypeCode.Empty)
                {
                    forgedTypeCode = overrideCode;
                }

                if (IsPrimitiveOrSimpleType(forgedTypeCode))
                {
                    sourceBuilder.AppendLine($"        writer.Write(instance.{prop.Name});");
                }
                else if(_generators.TryGetValue(prop.Type.Name, out var generator))
                {
                    sourceBuilder.AppendLine(generator.GenerateTypeCode(prop, attr, forgedTypeCode));
                }
                else if (HasSerializeExtensionMethod(context.Compilation, symbol))
                {
                    sourceBuilder.AppendLine($"        instance.{prop.Name}.Serialize(writer);");
                }
            }

            sourceBuilder.AppendLine("        }");
            sourceBuilder.AppendLine("    }");
            sourceBuilder.AppendLine("}");

            return sourceBuilder.ToString();
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