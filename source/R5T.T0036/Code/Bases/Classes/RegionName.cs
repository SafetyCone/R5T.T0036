using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RegionName : IRegionName
    {
        #region Static

        public static RegionName Instance { get; } = new();

        #endregion
    }
}