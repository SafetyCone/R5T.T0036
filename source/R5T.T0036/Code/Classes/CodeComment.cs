using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CodeComment : ICodeComment
    {
        #region Static

        public static CodeComment Instance { get; } = new();

        #endregion
    }
}