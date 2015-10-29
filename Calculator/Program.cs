//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="ABC">
//     Copyright (c) ABC Enterprises. All rights reserved.
// </copyright>
// <summary>This is the Program class.</summary>
// <author>Chirag Lad</author>
//-----------------------------------------------------------------------

namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Main program entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            Logic maths = new Logic();
            int result = maths.Addition(10, 20);
            maths.Display(result);

            Console.ReadLine();
        }
    }
}
