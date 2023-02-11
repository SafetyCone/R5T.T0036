using System;

using R5T.T0036;
using R5T.T0036.X005;


namespace System
{
    [Obsolete("See R5T.Z0027.IParameterNames")]
    public static class IParameterNameExtensions
    {
        public static string Args(this IParameterName _)
        {
            return ParameterNames.Args;
        }
    }
}
