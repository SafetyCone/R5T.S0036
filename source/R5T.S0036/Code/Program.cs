using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0133;
using R5T.T0134;


namespace R5T.S0036
{
    class Program
    {
        static Task Main()
        {
            Program.CreateServiceDefinitionInterface();

            return Task.CompletedTask;
        }

        private static void CreateServiceDefinitionInterface()
        {
            var compilationRequirement = Instances.CompilationUnitGenerator.CreateServiceDefinitionInterface();

            // Write compilation to example code file.
            Instances.SyntaxOperator_S0032_F001.WriteToExampleCodeFilePath(
                compilationRequirement.Node);

            // Write compilation unit compilation requirements to code file context.
        }
    }
}