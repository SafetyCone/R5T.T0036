﻿using System;

using Microsoft.CodeAnalysis;

using R5T.T0036;
using R5T.T0036.X003;

using Instances = R5T.T0036.X004.Instances;


namespace System
{
    [Obsolete("See R5T.Z0002.IIndentations")]
    public static class IIndentationExtensions
    {
        /// <summary>
        /// Initial indentation is just a new line.
        /// </summary>
        [Obsolete("See R5T.Z0002.IIndentations.Initial")]
        public static SyntaxTriviaList Initial(this IIndentation _)
        {
            var output = _.NewLine();
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.NewLine")]
        public static SyntaxTriviaList NewLine(this IIndentation _)
        {
            var output = new SyntaxTriviaList()
                .Add(Instances.SyntaxFactory.NewLine())
                ;

            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.BlankLine")]
        public static SyntaxTriviaList BlankLine(this IIndentation _)
        {
            var newLine = Instances.SyntaxFactory.NewLine();

            // A blank line is generated by two new line characters.
            var output = new SyntaxTriviaList(
                newLine,
                newLine);

            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.BlankLines_Two")]
        public static SyntaxTriviaList BlankLines_Two(this IIndentation _)
        {
            var newLine = Instances.SyntaxFactory.NewLine();

            // Two blank lines is generated by three new line characters.
            var output = new SyntaxTriviaList(
                newLine,
                newLine,
                newLine);

            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.BlankLines_Two")]
        public static SyntaxTriviaList ByTabCount(this IIndentation indentation,
            int tabCount)
        {
            var output = indentation.Initial()
                .IndentByTabs(tabCount)
                ;

            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Class")]
        public static SyntaxTriviaList Class(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.ClassBody")]
        public static SyntaxTriviaList ClassBody(this IIndentation indentation)
        {
            var tabCount = indentation.MethodTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.ClassEnding")]
        public static SyntaxTriviaList ClassEnding(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Documentation")]
        public static SyntaxTriviaList Documentation(this IIndentation indentation)
        {
            var tabCount = indentation.MethodTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Interface")]
        public static SyntaxTriviaList Interface(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.InterfaceBody")]
        public static SyntaxTriviaList InterfaceBody(this IIndentation indentation)
        {
            var tabCount = indentation.MethodTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Method")]
        public static SyntaxTriviaList Method(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.MethodTabCount());
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.MethodBody")]
        public static SyntaxTriviaList MethodBody(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.MethodBodyTabCount());
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.MethodParameter")]
        public static SyntaxTriviaList MethodParameter(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.MethodParameterTabCount());
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Namespace")]
        public static SyntaxTriviaList Namespace(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.NamespaceTabCount());
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.None")]
        public static SyntaxTriviaList None(this IIndentation _)
        {
            var output = new SyntaxTriviaList();
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Property")]
        public static SyntaxTriviaList Property(this IIndentation indentation)
        {
            var output = indentation.ByTabCount(indentation.PropertyTabCount());
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Statement")]
        public static SyntaxTriviaList Statement(this IIndentation indentation)
        {
            // Assumes statements are in the body of methods.
            var output = indentation.MethodBody();
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.Type")]
        public static SyntaxTriviaList Type(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }

        [Obsolete("See R5T.Z0002.IIndentations.TypeAttribute")]
        public static SyntaxTriviaList TypeAttribute(this IIndentation indentation)
        {
            var tabCount = indentation.ClassTabCount();

            var output = indentation.ByTabCount(tabCount);
            return output;
        }
    }
}
