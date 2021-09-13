using System;

using R5T.T0036;

using Instances = R5T.T0036.X005.Instances;


namespace System
{
    public static class IClassNameExtensions
    {
        public static string Class1(this IClassName _)
        {
            return Instances.TypeName.Class1();
        }

        public static string Program(this IClassName _)
        {
            return Instances.TypeName.Program();
        }

        public static string Startup(this IClassName _)
        {
            return Instances.TypeName.Startup();
        }
    }
}
