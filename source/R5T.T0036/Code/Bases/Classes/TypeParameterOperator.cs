using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeParameterOperator : ITypeParameterOperator
    {
        #region Static
        
        public static TypeParameterOperator Instance { get; } = new();

        #endregion
    }
}