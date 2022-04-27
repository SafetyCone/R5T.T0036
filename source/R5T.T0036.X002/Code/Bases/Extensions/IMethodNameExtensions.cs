using System;

using R5T.T0036;
using R5T.T0036.X001;


namespace System
{
    public static class IMethodNameExtensions
    {
        public static string AddSingleton(this IMethodName _)
        {
            return MicrosoftMethodNames.AddSingleton;
        }
    }
}