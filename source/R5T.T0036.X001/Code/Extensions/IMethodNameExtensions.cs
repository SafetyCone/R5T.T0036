using System;

using R5T.T0036;
using R5T.T0036.X001;


namespace System
{
    [Obsolete("See R5T.Z0027.IMethodNames")]
    public static class IMethodNameExtensions
    {
        public static string ToString(this IMethodName _)
        {
            return SystemMethodNames.ToString;
        }
    }
}