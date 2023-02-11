using System;

using R5T.T0036;

using Instances = R5T.T0036.X005.Instances;


namespace System
{
    [Obsolete("See R5T.F0104.IParameterNameOperator")]
    public static class IParameterNameOperatorExtensions
    {
        /// <summary>
        /// Removes the leading 'I' from interface type names to get the type name stem, then lowers the first character of the type name stem.
        /// </summary>
        public static string GetDefaultParameterNameForTypeName_HandleInterface(this IParameterNameOperator _,
            string typeName)
        {
            var typeNameStem = Instances.TypeNameOperator.GetTypeNameStem_HandleInterface(typeName);

            var output = typeNameStem[0].ToString().ToLowerInvariant() + typeNameStem[1..];
            return output;
        }

        /// <summary>
        /// Quality-of-life name for <see cref="GetDefaultParameterNameForTypeName_HandleInterface(IParameterNameOperator, string)"/>.
        /// </summary>
        public static string GetDefaultParameterNameForTypeName(this IParameterNameOperator _,
            string typeName)
        {
            var output = _.GetDefaultParameterNameForTypeName_HandleInterface(typeName);
            return output;
        }
    }
}
