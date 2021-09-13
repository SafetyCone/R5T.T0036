﻿using System;

using Microsoft.CodeAnalysis;

using R5T.T0036;
using R5T.T0036.X003;

using Instances = R5T.T0036.X004.Instances;


namespace System
{
    public static class IIndentationExtensions
    {
        /// <summary>
        /// Initial indentation is just a new line.
        /// </summary>
        public static SyntaxTriviaList Initial(this IIndentation _)
        {
            var output = _.NewLine();
            return output;
        }

        public static SyntaxTriviaList NewLine(this IIndentation _)
        {
            var output = new SyntaxTriviaList()
                .Add(Instances.SyntaxFactory.NewLine())
                ;

            return output;
        }

        public static SyntaxTriviaList ByTabCount(this IIndentation indentation,
            int tabCount)
        {
            var output = indentation.Initial()
                .IndentByTabs(tabCount)
                ;

            return output;
        }

        public static SyntaxTriviaList Class(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        public static SyntaxTriviaList ClassBody(this IIndentation indentation)
        {
            var tabCount = indentation.MethodTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        public static SyntaxTriviaList ClassEnding(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        public static SyntaxTriviaList Documentation(this IIndentation indentation)
        {
            var tabCount = indentation.MethodTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        public static SyntaxTriviaList Interface(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        public static SyntaxTriviaList InterfaceBody(this IIndentation indentation)
        {
            var tabCount = indentation.MethodTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        public static SyntaxTriviaList Method(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.MethodTabCount());
            return output;
        }

        public static SyntaxTriviaList MethodBody(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.MethodBodyTabCount());
            return output;
        }

        public static SyntaxTriviaList MethodParameter(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.MethodParameterTabCount());
            return output;
        }

        public static SyntaxTriviaList Namespace(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.NamespaceTabCount());
            return output;
        }

        public static SyntaxTriviaList None(this IIndentation _)
        {
            var output = new SyntaxTriviaList();
            return output;
        }

        public static SyntaxTriviaList Property(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.PropertyTabCount());
            return output;
        }

        public static SyntaxTriviaList Statement(this IIndentation indentation)
        {
            // Assumes statements are in the body of methods.
            var output = indentation.MethodBody();
            return output;
        }

        public static SyntaxTriviaList Type(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        public static SyntaxTriviaList TypeAttribute(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }
    }
}
