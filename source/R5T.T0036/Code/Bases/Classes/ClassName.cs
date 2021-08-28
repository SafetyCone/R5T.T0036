using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ClassName : IClassName
    {
        #region Static

        public static ClassName Instance { get; } = new();

        #endregion
    }
}