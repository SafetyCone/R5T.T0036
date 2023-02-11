using System;

using R5T.T0036;
using R5T.T0036.X003;


namespace System
{
    [Obsolete("See R5T.Z0027.ITypeParameterNames")]
    public static class ITypeParameterNameExtensions
    {
        public static string T(this ITypeParameterName _)
        {
            return TypeParameterNames.T;
        }
    }
}