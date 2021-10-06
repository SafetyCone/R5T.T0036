using System;

using R5T.T0036;


namespace System
{
    public static class IMethodNameOperatorExtensions
    {
        public static string GetTypedMethodName(this IMethodNameOperator _,
            string typeName,
            string methodName)
        {
            var output = $"{typeName}{Strings.Period}{methodName}";
            return output;
        }

        /// <summary>
        /// A full method name (or assemblied, namespaced, typed, parameterized, method name) is:
        /// R5T.T0054 - System.IEntryOperatorExtensions.HasEntryByIdentity(entries: IEnumerable&lt;Entry&gt;, entryIdentity: string)
        /// A typed method name is: IEntryOperatorExtensions.HasEntryByIdentity(), which includes the terminating empty paired parentheses to indicate the name is a method name.
        /// </summary>
        public static string GetTypedMethodNameFromFullMethodName(this IMethodNameOperator _,
            string fullMethodName)
        {
            var typeName = _.GetTypeNameFromFullMethodName(fullMethodName);
            var methodName = _.GetMethodNameFromFullMethodName(fullMethodName);

            var output = _.GetTypedMethodName(
                typeName,
                methodName);

            return output;
        }

        /// <summary>
        /// A full method name (or assemblied, namespaced, typed, parameterized, method name) is:
        /// R5T.T0054 - System.IEntryOperatorExtensions.HasEntryByIdentity(entries: IEnumerable&lt;Entry&gt;, entryIdentity: string)
        /// A method name is: HasEntryByIdentity(), which includes the terminating empty paired parentheses to indicate the name is a method name.
        /// </summary>
        public static string GetMethodNameFromFullMethodName(this IMethodNameOperator _,
            string fullMethodName)
        {
            // The method name is between the last period and open-parenthesis.
            var indexOfLastOpenParenthesis = fullMethodName.LastIndexOf(Characters.OpenParenthesis);
            if(!StringHelper.IsFound(indexOfLastOpenParenthesis))
            {
                throw new Exception($"Open parenthesis not found in full method name:\n{fullMethodName}");
            }

            var indexOfLastPeriod = fullMethodName.LastIndexOf(Characters.Period);
            if(!StringHelper.IsFound(indexOfLastPeriod))
            {
                throw new Exception($"Period not found in full method name:\n{fullMethodName}");
            }

            var methodLength = indexOfLastOpenParenthesis - 1 - indexOfLastPeriod;

            var methodNameWithoutParentheses = fullMethodName.Substring(indexOfLastPeriod + 1, methodLength);

            var output = $"{methodNameWithoutParentheses}{Strings.PairedParentheses}";
            return output;
        }

        /// <summary>
        /// A full method name (or assemblied, namespaced, typed, parameterized, method name) is:
        /// R5T.T0054 - System.IEntryOperatorExtensions.HasEntryByIdentity(entries: IEnumerable&lt;Entry&gt;, entryIdentity: string)
        /// The type name is: IEntryOperatorExtensions.
        /// </summary>
        public static string GetTypeNameFromFullMethodName(this IMethodNameOperator _,
            string fullMethodName)
        {
            // The type name is between the second-to-last and last period.
            var indexOfLastPeriod = fullMethodName.LastIndexOf(Characters.Period);
            if (!StringHelper.IsFound(indexOfLastPeriod))
            {
                throw new Exception($"Period not found in full method name:\n{fullMethodName}");
            }

            var lengthOfSubstringBeforeLastPeriod = indexOfLastPeriod; // Length is index plus one.

            var subStringBeforeLastPeriod = fullMethodName.Substring(0, lengthOfSubstringBeforeLastPeriod);

            var indexOfSecondToLastPeriod = subStringBeforeLastPeriod.LastIndexOf(Characters.Period);
            if(!StringHelper.IsFound(indexOfSecondToLastPeriod))
            {
                throw new Exception($"Second to last period not found in full method name:\n{fullMethodName}");
            }

            var lengthOfTypeName = indexOfLastPeriod - 1 - indexOfSecondToLastPeriod;

            var typeName = fullMethodName.Substring(indexOfSecondToLastPeriod + 1, lengthOfTypeName);
            return typeName;
        }
    }
}