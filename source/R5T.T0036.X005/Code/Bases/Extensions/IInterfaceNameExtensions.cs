﻿using System;

using R5T.T0036;

using Instances = R5T.T0036.X005.Instances;


namespace System
{
    [Obsolete("See R5T.Z0027.InterfaceNames")]
    public static class IInterfaceNameExtensions
    {
        public static string Interface1(this IInterfaceName _)
        {
            return Instances.TypeName_Old.Interface1();
        }
    }
}
