﻿using Sorting_Program;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InsertionSortTest
{
    
    
    /// <summary>
    ///This is a test class for frmMainTest and is intended
    ///to contain all frmMainTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmMainTest
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
        ///A test for insertionSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]
        public void insertionSortTest1()
        {
            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = { 10, 2, 7, 70, 50 }; // TODO: Initialize to an appropriate value
            int[] arrExpected = { 2, 7, 10, 50, 70 }; // TODO: Initialize to an appropriate value
            int last = 4; // TODO: Initialize to an appropriate value
           // int[] expected = { 2, 7, 10, 50, 70 }; // TODO: Initialize to an appropriate value
            int[] actual = target.insertionSort(arr, last);
            Assert.AreEqual(arrExpected, actual);
            //Assert.AreEqual(expected, actual);
            //  Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
