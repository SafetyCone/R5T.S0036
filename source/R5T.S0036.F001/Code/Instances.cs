using System;

using R5T.F0008;

using ISyntaxGenerator_Base = R5T.B0006.ISyntaxGenerator;


namespace R5T.S0036.F001
{
    public static class Instances
    {
        public static B0001.ITypeNameOperator TypeNameOperator { get; } = B0001.TypeNameOperator.Instance;
        public static B0007.IIndentationGenerator IndentationGenerator { get; } = B0007.IndentationGenerator.Instance;
        public static B0003.INamespacedTypeNameOperator NamespacedTypeNameOperator { get; } = B0003.NamespacedTypeNameOperator.Instance;
        public static B0007.ISpacingGenerator SpacingGenerator { get; } = B0007.SpacingGenerator.Instance;
        public static ISyntaxGenerator SyntaxGenerator { get; } = F0008.SyntaxGenerator.Instance;
        public static ISyntaxGenerator_Base SyntaxGenerator_Base { get; } = B0006.SyntaxGenerator.Instance;
    }
}
