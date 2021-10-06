using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class MethodNameOperator : IMethodNameOperator
    {
        #region Static
        
        public static MethodNameOperator Instance { get; } = new();

        #endregion
    }
}