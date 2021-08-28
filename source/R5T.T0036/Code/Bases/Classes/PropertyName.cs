using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class PropertyName : IPropertyName
    {
        #region Static

        public static PropertyName Instance { get; } = new();

        #endregion
    }
}