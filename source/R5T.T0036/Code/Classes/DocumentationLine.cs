using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class DocumentationLine : IDocumentationLine
    {
        #region Static

        public static DocumentationLine Instance { get; } = new();

        #endregion
    }
}