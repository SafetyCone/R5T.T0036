using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class MethodName : IMethodName
    {
        #region Static

        public static MethodName Instance { get; } = new();

        #endregion
    }
}