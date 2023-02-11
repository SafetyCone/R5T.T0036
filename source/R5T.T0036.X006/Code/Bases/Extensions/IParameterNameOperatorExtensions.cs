using System;

using R5T.Magyar;

using R5T.T0036;

using Instances = R5T.T0036.X006.Instances;


namespace System
{
    [Obsolete("See R5T.F0104.IParameterNameOperator")]
    public static class IParameterNameOperatorExtensions
    {
        public static string GetExtensionTypeName(this IParameterNameOperator _,
            string extensionParameter)
        {
            var tokens = extensionParameter.Split(Characters.Space);

            if(tokens.Length != 3)
            {
                throw new Exception($"Extension parameter '{extensionParameter}' did not include:\n1) '{Instances.Syntax.This()}' extension parameter modifier,\n2) the parameter type, and\n3) the parameter name.");
            }

            var output = tokens[1];
            return output;
        }
    }
}
