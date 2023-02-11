using System;

using R5T.T0036;
using R5T.T0036.X005;


namespace System
{
    public static class IMethodNameExtensions
    {
        [Obsolete("See R5T.Z0027.IMethodNames")]
        public static string Main(this IMethodName _)
        {
            return MethodNames.Main;
        }
    }
}
