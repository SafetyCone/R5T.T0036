using System;

using R5T.T0036;

using Instances = R5T.T0036.X005.Instances;


namespace System
{
    public static class IClassNameExtensions
    {
        public static string Program(this IClassName _)
        {
            return Instances.TypeName.Program();
        }
    }
}
