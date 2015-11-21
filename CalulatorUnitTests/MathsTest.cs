//-----------------------------------------------------------------------
// <copyright file="MathTest.cs" company="ABC">
//     Copyright (c) ABC Enterprises. All rights reserved.
// </copyright>
// <summary>This is the MathTest class.</summary>
// <author>Chirag Lad</author>
//-----------------------------------------------------------------------
namespace CalulatorUnitTests
{
    using Calculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    
    /// <summary>
    ///This is a test class for LogicTest and is intended
    ///to contain all LogicTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogicTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Addition
        ///</summary>
        [TestMethod()]
        public void AdditionTest()
        {
            Logic target = new Logic(); // TODO: Initialize to an appropriate value
            int a = 50; // TODO: Initialize to an appropriate value
            int b = 50; // TODO: Initialize to an appropriate value
            int expected = 100; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Addition(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Division
        ///</summary>
        [TestMethod()]
        public void DivisionTest()
        {
            Logic target = new Logic(); // TODO: Initialize to an appropriate value
            int a = 10; // TODO: Initialize to an appropriate value
            int b = 5; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Multiplication
        ///</summary>
        [TestMethod()]
        public void MultiplicationTest()
        {
            Logic target = new Logic(); // TODO: Initialize to an appropriate value
            int a = 2; // TODO: Initialize to an appropriate value
            int b = 5; // TODO: Initialize to an appropriate value
            int expected = 10; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Substarction
        ///</summary>
        [TestMethod()]
        public void SubstarctionTest()
        {
            Logic target = new Logic(); // TODO: Initialize to an appropriate value
            int a = 10; // TODO: Initialize to an appropriate value
            int b = 5; // TODO: Initialize to an appropriate value
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Substarction(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
