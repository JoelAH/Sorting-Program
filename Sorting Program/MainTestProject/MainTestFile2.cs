using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting_Program;

namespace MainTestProject
{
    /// <summary>
    /// Summary description for MainTestFile2
    /// </summary>
    [TestClass]
    public class MainTestFile2
    {
        public MainTestFile2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        ///A test for shellSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void shellSortTest1()
        {
            /*Description:tests to check if shell function works
            * (Arguments)->return type: (void)->void
            *Precondition: actual main form and functions must exist
            * Postcondition:expected array and the actual returned array is checked to see if equal
            * Example(s): {9,8} passed, {8,9} is returned, the test passed*/


            // test with huge negatives

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = {-89000,-200000,-1000000,-50000}; // TODO: Initialize to an appropriate value
            int[] arrExpected = {-1000000,-200000,-89000,-50000}; // TODO: Initialize to an appropriate value
            const int SIZE = 4;
            int last = SIZE - 1; // TODO: Initialize to an appropriate value


            int[] actual = target.shellSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for shellSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void shellSortTest2()
        {
            /*Description:tests to check if shell function works
            * (Arguments)->return type: (void)->void
            *Precondition: actual main form and functions must exist
            * Postcondition:expected array and the actual returned array is checked to see if equal
            * Example(s): {9,8} passed, {8,9} is returned, the test passed*/


            // test with mixture of huge negatives and normal positives

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = { -89000, 6, -1000000, -50000,0,35,-6700,90,345,1 }; // TODO: Initialize to an appropriate value
            int[] arrExpected = { -1000000,  -89000, -50000,-6700,0,1,6,35,90,345 }; // TODO: Initialize to an appropriate value
            const int SIZE = 10;
            int last = SIZE - 1; // TODO: Initialize to an appropriate value


            int[] actual = target.shellSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for shellSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void shellSortTest3()
        {
            /*Description:tests to check if shell function works
            * (Arguments)->return type: (void)->void
            *Precondition: actual main form and functions must exist
            * Postcondition:expected array and the actual returned array is checked to see if equal
            * Example(s): {9,8} passed, {8,9} is returned, the test passed*/


            // test with all numbers the same

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = { 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498 }; // TODO: Initialize to an appropriate value
            int[] arrExpected = { 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498, 498 }; // TODO: Initialize to an appropriate value
            const int SIZE = 15;
            int last = SIZE - 1; // TODO: Initialize to an appropriate value


            int[] actual = target.shellSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
