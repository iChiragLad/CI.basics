//-----------------------------------------------------------------------
// <copyright file="Logic.cs" company="ABC">
//     Copyright (c) ABC Enterprises. All rights reserved.
// </copyright>
// <summary>This is the Logic class.</summary>
// <author>Chirag Lad</author>
//-----------------------------------------------------------------------

namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Logic behind the calculator.
    /// </summary>
    public class Logic
    {
        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1515:SingleLineCommentMustBePrecededByBlankLine", Justification = "Reviewed.")]

        /// <summary>
        /// Perform addition on the input parameters.
        /// </summary>
        /// <param name="a">First parameter.</param>
        /// <param name="b">Second parameter.</param>
        /// <returns>Returns integer.</returns>
        // <CreatedBy>Chirag Lad.</CreatedBy>
        public int Addition(int a, int b)
        {
            return a + b;
        }

        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1515:SingleLineCommentMustBePrecededByBlankLine", Justification = "Reviewed.")]

        /// <summary>
        /// Perform subtraction on the input parameters.
        /// </summary>
        /// <param name="a">First parameter.</param>
        /// <param name="b">Second parameter.</param>
        /// <returns>Returns integer.</returns>
        // <CreatedBy>Chirag Lad.</CreatedBy>
        public int Substarction(int a, int b)
        {
            return a - b;
        }

        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1515:SingleLineCommentMustBePrecededByBlankLine", Justification = "Reviewed.")]

        /// <summary>
        /// Perform Multiplication on the input parameters.
        /// </summary>
        /// <param name="a">First parameter.</param>
        /// <param name="b">Second parameter.</param>
        /// <returns>Returns integer.</returns>
        // <CreatedBy>Chirag Lad.</CreatedBy>
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1515:SingleLineCommentMustBePrecededByBlankLine", Justification = "Reviewed.")]

        /// <summary>
        /// Perform Division on the input parameters.
        /// </summary>
        /// <param name="a">First parameter.</param>
        /// <param name="b">Second parameter.</param>
        /// <returns>Returns integer.</returns>
        // <CreatedBy>Chirag La</CreatedBy>
        public int Division(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Displays the specified result.
        /// </summary>
        /// <param name="result">The result.</param>
        public void Display(int result)
        {
            Console.WriteLine("Answer is : {0}", result);
        }
    }
}
