using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ParameterName : IParameterName
    {
        #region Static

        public static ParameterName Instance { get; } = new();

        #endregion
    }
}