using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeParameterName : ITypeParameterName
    {
        #region Static

        public static TypeParameterName Instance { get; } = new();

        #endregion
    }
}