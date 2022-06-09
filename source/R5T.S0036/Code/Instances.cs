using System;

using R5T.B0001;
using R5T.B0003;
using R5T.B0006;
using R5T.B0007;


namespace R5T.S0036
{
    public static class Instances
    {
        public static ICodeFileContextProvider CodeFileContextProvider { get; } = S0036.CodeFileContextProvider.Instance;
        public static F001.ICompilationUnitGenerator CompilationUnitGenerator { get; } = F001.CompilationUnitGenerator.Instance;
        public static ITypeNameOperator TypeNameOperator { get; } = B0001.TypeNameOperator.Instance;
        public static IIndentationGenerator IndentationGenerator { get; } = B0007.IndentationGenerator.Instance;
        public static INamespacedTypeNameOperator NamespacedTypeNameOperator { get; } = B0003.NamespacedTypeNameOperator.Instance;
        public static S0032.F001.ISyntaxOperator SyntaxOperator_S0032_F001 { get; } = S0032.F001.SyntaxOperator.Instance;
        public static ISpacingGenerator SpacingGenerator { get; } = B0007.SpacingGenerator.Instance;
        public static ISyntaxGenerator SyntaxGenerator { get; } = B0006.SyntaxGenerator.Instance;
    }
}
