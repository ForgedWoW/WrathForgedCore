// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WrathForged.Serialization.Models;

namespace WrathForged.Serialization
{
    public class SerializationSyntaxReceiver : ISyntaxReceiver
    {
        public List<ClassDeclarationSyntax> CandidateClasses { get; } = new List<ClassDeclarationSyntax>();
        public List<RecordDeclarationSyntax> CandidateRecords { get; } = new List<RecordDeclarationSyntax>();
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

            if (syntaxNode is RecordDeclarationSyntax recordDeclarationSyntax
               && recordDeclarationSyntax.AttributeLists.Count > 0)
            {
                foreach (var attributeList in recordDeclarationSyntax.AttributeLists)
                {
                    foreach (var attribute in attributeList.Attributes)
                    {
                        if (attribute.Name.ToString().Contains(_attributeName))
                        {
                            CandidateRecords.Add(recordDeclarationSyntax);
                            return; // No need to check further attributes for this class
                        }
                    }
                }
            }
        }
    }
}