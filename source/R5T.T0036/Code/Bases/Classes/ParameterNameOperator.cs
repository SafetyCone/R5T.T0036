using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ParameterNameOperator : IParameterNameOperator
    {
        #region Static
        
        public static ParameterNameOperator Instance { get; } = new();

        #endregion
    }
}