using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WrathForged.Serialization
{
    public class SerializationSyntaxReceiver : ISyntaxReceiver
    {
        public List<ClassDeclarationSyntax> CandidateClasses { get; } = new List<ClassDeclarationSyntax>();
        private readonly string _attributeName = nameof(ForgedSerializableAttribute).Replace("Attribute", "");

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            // Check if it's a class with our attribute
            if (syntaxNode is ClassDeclarationSyntax classDeclarationSyntax
                && classDeclarationSyntax.AttributeLists.Count > 0)
            {
                foreach (var attributeList in classDeclarationSyntax.AttributeLists)
                {
                    foreach (var attribute in attributeList.Attributes)
                    {
                        if (attribute.Name.ToString().Contains(_attributeName))
                        {
                            CandidateClasses.Add(classDeclarationSyntax);
                            return; // No need to check further attributes for this class
                        }
                    }
                }
            }
        }
    }

}
