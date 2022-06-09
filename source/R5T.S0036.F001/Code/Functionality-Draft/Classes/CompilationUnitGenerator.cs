using System;


namespace R5T.S0036.F001
{
    public class CompilationUnitGenerator : ICompilationUnitGenerator
    {
        #region Infrastructure

        public static CompilationUnitGenerator Instance { get; } = new();

        private CompilationUnitGenerator()
        {
        }

        #endregion
    }
}
