using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;
using R5T.T0133;
using R5T.T0134;


namespace R5T.S0036.F001
{
    [DraftFunctionalityMarker]
    public partial interface ICompilationUnitGenerator : IDraftFunctionalityMarker
    {
        public CompilationRequirements<CompilationUnitSyntax> CreateServiceDefinitionInterface()
        {
            /// Inputs.
            var namespaceName = "R5T.S0030.T003.N011";
            var serviceNameStem = "SolutionFileSetContextProvider";
            var serviceDefinitionInterfaceTypeName = "I" + serviceNameStem;


            /// Run.
            var serviceDefinitionMarkerAttributeNamespacedTypeName = "R5T.T0064.ServiceDefinitionMarkerAttribute";
            var serviceDefinitionMarkerAttributeTypeName = Instances.TypeNameOperator.GetEnsuredNonAttributeSuffixedTypeName(
                Instances.NamespacedTypeNameOperator.GetTypeName(serviceDefinitionMarkerAttributeNamespacedTypeName));
            var serviceDefinitionMarkerAttributeNamespaceName = Instances.NamespacedTypeNameOperator.GetNamespaceName(serviceDefinitionMarkerAttributeNamespacedTypeName);

            // Would be gotten from project repository, but ok for now.
            var serviceDefinitionMarkerAttributeProjectPath = @"<R5T.T0064 project path>";

            var compilationUnit = Instances.SyntaxGenerator_Base.CompilationUnit();

            var usingSystemNamespace = Instances.SyntaxGenerator.UsingSystemNamespace();

            ISyntaxNodeAnnotation<UsingDirectiveSyntax> usingDirectiveAnnotation;
            (compilationUnit, usingDirectiveAnnotation) = compilationUnit.AddUsingDirective(usingSystemNamespace);

            var @namespace = Instances.SyntaxGenerator_Base.Namespace(namespaceName);

            ISyntaxNodeAnnotation<NamespaceDeclarationSyntax> namespaceAnnotation;
            (compilationUnit, namespaceAnnotation) = compilationUnit.AddNamespace(@namespace);

            var namespaceSpacing = Instances.SpacingGenerator.TwoBlankLines();

            compilationUnit = namespaceAnnotation.Modify(
                compilationUnit,
                @namespace => @namespace.WithLeadingTrivia(namespaceSpacing));

            var @interface = Instances.SyntaxGenerator_Base.Interface(serviceDefinitionInterfaceTypeName);

            //compilationUnit = namespaceAnnotation.Modify(
            //    compilationUnit,
            //    @namespace => @namespace.AddMembers(@interface));

            ISyntaxNodeAnnotation<InterfaceDeclarationSyntax> interfaceAnnotation;
            (compilationUnit, interfaceAnnotation) = namespaceAnnotation.AddMemberWithResult(
                compilationUnit,
                @interface);

            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface => @interface
                    .MakePublicWithResult().DiscardAnnotation());

            var attribute = Instances.SyntaxGenerator_Base.Attribute(serviceDefinitionMarkerAttributeTypeName);

            ISyntaxNodeAnnotation<AttributeSyntax> attributeAnnotation = SyntaxNodeAnnotation.Initialize<AttributeSyntax>();
            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface =>
                {
                    (@interface, attributeAnnotation) = @interface.AddAttribute(attribute);

                    return @interface;
                });

            // Indentation.
            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface => @interface
                    .PrependNewLine()
                    .Indent(
                        Instances.IndentationGenerator.ForInterface()));

            var compilationRequirements = CompilationRequirements.From(compilationUnit)
                .AddNamespaceName(serviceDefinitionMarkerAttributeNamespaceName)
                .AddProjectReferenceFilePath(serviceDefinitionMarkerAttributeProjectPath)
                ;

            return compilationRequirements;
        }
    }
}
