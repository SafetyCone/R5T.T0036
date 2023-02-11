using System;


namespace R5T.T0036.X003
{
    [Obsolete("See R5T.Z0002.ITabCounts")]
    public static class IIndentationExtensions
    {
        public static int ClassTabCount(this IIndentation _)
        {
            return IndentationTabCounts.ClassTabCount;
        }

        public static int InterfaceOuterTabCount(this IIndentation _)
        {
            return IndentationTabCounts.InterfaceOuterTabCount;
        }

        public static int MethodTabCount(this IIndentation _)
        {
            return IndentationTabCounts.MethodTabCount;
        }

        public static int MethodBodyTabCount(this IIndentation _)
        {
            return IndentationTabCounts.MethodBodyTabCount;
        }

        public static int MethodParameterTabCount(this IIndentation _)
        {
            return IndentationTabCounts.MethodParameterTabCount;
        }

        public static int NamespaceTabCount(this IIndentation _)
        {
            return IndentationTabCounts.NamespaceTabCount;
        }

        public static int NoneTabCount(this IIndentation _)
        {
            return IndentationTabCounts.NamespaceTabCount;
        }

        public static int ParameterTabCount(this IIndentation _)
        {
            return IndentationTabCounts.Parameter;
        }

        public static int PropertyTabCount(this IIndentation _)
        {
            return IndentationTabCounts.PropertyTabCount;
        }
    }
}
