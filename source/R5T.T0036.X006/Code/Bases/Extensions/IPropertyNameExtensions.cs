using System;

using R5T.T0036;

using Instances = R5T.T0036.X006.Instances;


namespace System
{
    [Obsolete("See R5T.F0104.IPropertyNameOperator")]
    public static class IPropertyNameExtensions
    {
        public static string GetPropertyNameForTypeName(this IPropertyName _,
            string typeName)
        {
            var isInterface = Instances.TypeName.IsInterface(typeName); // TODO, using R5T.T0034.T001.X001 ITypeNameAffix.InterfaceNamePrefix() in a new library R5T.T0036.X###.

            var output = isInterface
                ? Instances.TypeName.GetTypeNameStemFromInterfaceName(typeName)
                : typeName
                ;

            return output;
        }
    }
}
