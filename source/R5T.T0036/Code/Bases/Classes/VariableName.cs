using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class VariableName : IVariableName
    {
        #region Static

        public static VariableName Instance { get; } = new();

        #endregion
    }
}