using System;


namespace R5T.T0036
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class InterfaceName : IInterfaceName
    {
        #region Static

        public static InterfaceName Instance { get; } = new();

        #endregion
    }
}