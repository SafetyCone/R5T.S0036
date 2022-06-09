using System;


namespace R5T.S0036
{

    public class CodeFileContextProvider : ICodeFileContextProvider
    {
        #region Infrastructure

        public static CodeFileContextProvider Instance { get; } = new();

        private CodeFileContextProvider()
        {
        }

        #endregion
    }
}
