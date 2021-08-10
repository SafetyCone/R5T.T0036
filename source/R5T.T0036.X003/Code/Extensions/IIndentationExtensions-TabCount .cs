using System;


namespace R5T.T0036.X003
{
    public static class IIndentationExtensions
    {
        public static int ClassTabCount(this IIndentation _)
        {
            return IndentationValues.ClassTabCount;
        }

        public static int InterfaceOuterTabCount(this IIndentation _)
        {
            return IndentationValues.InterfaceOuterTabCount;
        }

        public static int MethodTabCount(this IIndentation _)
        {
            return IndentationValues.MethodTabCount;
        }

        public static int MethodBodyTabCount(this IIndentation _)
        {
            return IndentationValues.MethodBodyTabCount;
        }

        public static int MethodParameterTabCount(this IIndentation _)
        {
            return IndentationValues.MethodParameterTabCount;
        }

        public static int NamespaceTabCount(this IIndentation _)
        {
            return IndentationValues.NamespaceTabCount;
        }

        public static int NoneTabCount(this IIndentation _)
        {
            return IndentationValues.NamespaceTabCount;
        }

        public static int ParameterTabCount(this IIndentation _)
        {
            return IndentationValues.Parameter;
        }

        public static int PropertyTabCount(this IIndentation _)
        {
            return IndentationValues.PropertyTabCount;
        }
    }
}
