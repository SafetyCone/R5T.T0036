using System;

using R5T.Magyar;

using R5T.T0036;

using Instances = R5T.T0036.X006.Instances;


namespace System
{
    [Obsolete("See R5T.F0104.IMethodNameOperator")]
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
            var indexOfFirstOpenParenthesis = _.GetIndexOfFirstOpenParenthesis(fullMethodName);
            if (!StringHelper.IsFound(indexOfFirstOpenParenthesis))
            {
                throw new Exception($"Open parenthesis ('(') not found in full method name:\n{fullMethodName}");
            }

            var indexOfFirstOpenAngleBrace = _.GetIndexOfFirstOpenAngleBraceOrNotFound(fullMethodName);

            var indexOfMethodNameStop = IndexHelper.IsFound(indexOfFirstOpenAngleBrace) && indexOfFirstOpenAngleBrace < indexOfFirstOpenParenthesis
                ? indexOfFirstOpenAngleBrace
                : indexOfFirstOpenParenthesis
                ;

            var indexOfLastPeriod = fullMethodName.LastIndexOf(Characters.Period, indexOfFirstOpenParenthesis);
            if(!StringHelper.IsFound(indexOfLastPeriod))
            {
                throw new Exception($"Period ('.') not found in full method name:\n{fullMethodName}");
            }

            var methodLength = indexOfMethodNameStop - 1 - indexOfLastPeriod;

            var methodNameWithoutParentheses = fullMethodName.Substring(indexOfLastPeriod + 1, methodLength);

            var output = $"{methodNameWithoutParentheses}{Strings.PairedParentheses}";
            return output;
        }

        public static string GetMethodNameFromFullMethodNameWithoutParentheses(this IMethodNameOperator _,
            string fullMethodName)
        {
            var output = _.GetMethodNameFromFullMethodName(fullMethodName)
                .TrimEnd(Characters.OpenParenthesis, Characters.CloseParenthesis)
                ;

            return output;
        }

        public static int GetIndexOfFirstOpenParenthesis(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var output = parameterizedMethodName.IndexOf(Characters.OpenParenthesis);
            if (!StringHelper.IsFound(output))
            {
                throw new Exception($"Open parenthesis not found in method name:\n{parameterizedMethodName}");
            }

            return output;
        }

        public static int GetIndexOfFirstOpenAngleBraceOrNotFound(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var output = parameterizedMethodName.IndexOf(Characters.OpenAngleBrace);
            return output;
        }

        public static int GetIndexOfLastOpenParenthesis(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var output = parameterizedMethodName.LastIndexOf(Characters.OpenParenthesis);
            if (!StringHelper.IsFound(output))
            {
                throw new Exception($"Open parenthesis not found in method name:\n{parameterizedMethodName}");
            }

            return output;
        }

        public static int GetIndexOfNextCloseParenthesis(this IMethodNameOperator _,
            string parameterizedMethodName,
            int startIndex)
        {
            var output = parameterizedMethodName.IndexOf(Characters.CloseParenthesis, startIndex);
            if (!StringHelper.IsFound(output))
            {
                throw new Exception($"Close parenthesis not found in method name:\n{parameterizedMethodName}");
            }

            return output;
        }

        public static int GetIndexOfLastCloseParenthesis(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var output = parameterizedMethodName.LastIndexOf(Characters.CloseParenthesis);
            if (!StringHelper.IsFound(output))
            {
                throw new Exception($"Close parenthesis not found in method name:\n{parameterizedMethodName}");
            }

            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetParameterListParenthesied(IMethodNameOperator, string)"/> as the default.
        /// </summary>
        public static string GetParameterList(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var output = _.GetParameterListParenthesied(parameterizedMethodName);
            return output;
        }

        public static string GetParameterListParenthesied(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            // The parameter list (parenthsied) extends from the last open parenthesis of the parameterized method name to the end.
            var indexOfFirstOpenParenthesis = _.GetIndexOfFirstOpenParenthesis(parameterizedMethodName);

            var output = parameterizedMethodName[indexOfFirstOpenParenthesis..];
            return output;
        }

        public static string GetParameterListUnParenthesied(this IMethodNameOperator _,
            string fullMethodName)
        {
            var output = _.GetParameterListParenthesied(fullMethodName)
                .TrimStart(Characters.OpenParenthesis)
                .TrimEnd(Characters.CloseParenthesis)
                ;

            return output;
        }

        public static string GetParameterizedMethodName(this IMethodNameOperator _,
            string fullMethodName)
        {
            var methodName = _.GetMethodNameFromFullMethodNameWithoutParentheses(fullMethodName);
            var parameterList = _.GetParameterList(fullMethodName);

            var output = $"{methodName}{parameterList}";
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

        public static string GetNamespacedTypedMethodName(this IMethodNameOperator _,
            string namespacedTypeName,
            string methodName)
        {
            var output = $"{namespacedTypeName}{Strings.Period}{methodName}";
            return output;
        }

        public static string GetNamespacedTypedParameterizedMethodName(this IMethodNameOperator _,
            string namespacedTypeName,
            string parameterizedMethodName)
        {
            var output = $"{namespacedTypeName}{Strings.Period}{parameterizedMethodName}";
            return output;
        }

        public static string GetNamespacedTypedParameterizedMethodNameFromFullMethodName(this IMethodNameOperator _,
            string namespacedTypeName,
            string fullMethodName)
        {
            var parameterizedMethodName = _.GetParameterizedMethodName(fullMethodName);

            var output = _.GetNamespacedTypedParameterizedMethodName(
                namespacedTypeName,
                parameterizedMethodName);

            return output;
        }

        public static WasFound<string> HasFirstParameter(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var indexOfOpenParenthesis = _.GetIndexOfFirstOpenParenthesis(parameterizedMethodName);
            var indexOfNextCloseParenthesis = _.GetIndexOfNextCloseParenthesis(parameterizedMethodName, indexOfOpenParenthesis);

            // Is there even a single parameter?
            if(indexOfNextCloseParenthesis == indexOfOpenParenthesis + 1)
            {
                return WasFound.NotFound<string>();
            }

            // Get the first parameter.
            var indexOfFirstNextCommaOrNotFound = parameterizedMethodName.IndexOf(Characters.Comma, indexOfOpenParenthesis);
            var indexOfFirstNextCommaOrNextCloseParenthesis = StringHelper.IsFound(indexOfFirstNextCommaOrNotFound)
                ? indexOfFirstNextCommaOrNotFound
                : indexOfNextCloseParenthesis
                ;

            var firstParameter = parameterizedMethodName.Substring(indexOfOpenParenthesis + 1, indexOfFirstNextCommaOrNextCloseParenthesis - indexOfOpenParenthesis);

            var output = WasFound.From(firstParameter);
            return output;
        }

        public static WasFound<string> HasExtensionParameter(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            // Does the method even have a single parameter?
            var hasFirstParameter = _.HasFirstParameter(parameterizedMethodName);
            if(!hasFirstParameter)
            {
                return hasFirstParameter;
            }

            // Ok, at least the method has a parameter.
            // Is the first parameter modified with the extension parameter signifier, 'this'?
            var tokens = hasFirstParameter.Result.Split(Characters.Space);

            var firstToken = tokens[0];

            var firstTokenIsExtensionParameterSignifier = firstToken == Instances.Syntax.This();

            var output = firstTokenIsExtensionParameterSignifier
                ? hasFirstParameter
                : WasFound.NotFound<string>()
                ;

            return output;
        }

        public static string GetExtensionParameter(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var hasExtensionParameter = _.HasExtensionParameter(parameterizedMethodName);

            var output = hasExtensionParameter.GetOrExceptionIfNotFound($"No extension parameter found on parameterized method name:\n{parameterizedMethodName}");
            return output;
        }

        public static string GetExtensionTypedMethodName(this IMethodNameOperator _,
            string typedParameterizedExtensionMethodName)
        {
            var extensionParameter = _.GetExtensionParameter(typedParameterizedExtensionMethodName);

            var extensionTypeName = Instances.ParameterNameOperator.GetExtensionTypeName(extensionParameter);

            var methodName = _.GetMethodNameFromFullMethodName(typedParameterizedExtensionMethodName);

            var output = $"{extensionTypeName}.{methodName}";
            return output;
        }

        public static string GetParameterListWithoutExtensionParameterUnParenthesied(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var parameterListUnParenthesied = _.GetParameterListUnParenthesied(parameterizedMethodName);

            var hasExtensionParameter = _.HasExtensionParameter(parameterizedMethodName);
            if(hasExtensionParameter)
            {
                var indexOfFirstCommaOrNotFound = parameterListUnParenthesied.IndexOf(Strings.Comma);

                var restOfParameterList = StringHelper.IsFound(indexOfFirstCommaOrNotFound)
                    ? parameterListUnParenthesied[(indexOfFirstCommaOrNotFound + 1)..].TrimStart()
                    : Strings.Empty
                    ;

                return restOfParameterList;
            }
            else
            {
                return parameterListUnParenthesied;
            }
        }

        public static string GetParameterListWithoutExtensionParameter(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var parameterListWithoutExtensionParameterUnParenthesied = _.GetParameterListWithoutExtensionParameterUnParenthesied(parameterizedMethodName);

            var output = $"({parameterListWithoutExtensionParameterUnParenthesied})";
            return output;
        }

        public static string GetMethodNameWithoutExtensionParameter(this IMethodNameOperator _,
            string parameterizedMethodName)
        {
            var indexOfFirstOpenParenthesisOrNotFound = parameterizedMethodName.IndexOf(Characters.OpenParenthesis);

            if(StringHelper.NotFound(indexOfFirstOpenParenthesisOrNotFound))
            {
                return parameterizedMethodName;
            }

            var methodRoot = parameterizedMethodName.Substring(0, indexOfFirstOpenParenthesisOrNotFound);

            var parameterListWithoutExtensionParameter = _.GetParameterListWithoutExtensionParameter(parameterizedMethodName);

            var output = $"{methodRoot}{parameterListWithoutExtensionParameter}";
            return output;
        }
    }
}