using System;

using R5T.L0011.T002;
using R5T.T0034;


namespace R5T.T0036.X006
{
    public static class Instances
    {
        public static IParameterNameOperator ParameterNameOperator { get; } = T0036.ParameterNameOperator.Instance;
        public static ISyntax Syntax { get; } = L0011.T002.Syntax.Instance;
        public static ITypeName TypeName { get; } = T0034.TypeName.Instance;
    }
}
