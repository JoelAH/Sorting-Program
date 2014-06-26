using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting_Program;

namespace MainTestProject
{
    /// <summary>
    /// Summary description for MainTestFile3
    /// </summary>
    [TestClass]
    public class MainTestFile3
    {
        public MainTestFile3()
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
        ///A test for bubbleSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void bubbleSortTest1()
        {
            /*Description:tests to check if bubble function works
            * (Arguments)->return type: (void)->void
            *Precondition: actual main form and functions must exist
            * Postcondition:expected array and the actual returned array is checked to see if equal
            * Example(s): {9,8} passed, {8,9} is returned, the test passed*/


            // test duplicates of negative and positive

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = { -89001,3,3,-89001,905,87,-89001,99,99,-3,89001,0}; // TODO: Initialize to an appropriate value
            int[] arrExpected = {-89001,-89001,-89001,-3,0,3,3,87,99,99,905,89001}; // TODO: Initialize to an appropriate value
            const int SIZE = 12;
            int last = SIZE - 1; // TODO: Initialize to an appropriate value


            int[] actual = target.insertionSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for bubbleSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void bubbleSortTest2()
        {
            /*Description:tests to check if bubble function works
           * (Arguments)->return type: (void)->void
           *Precondition: actual main form and functions must exist
           * Postcondition:expected array and the actual returned array is checked to see if equal
           * Example(s): {9,8} passed, {8,9} is returned, the test passed*/

            //test with an array of 100 values consisting  duplicate values

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = { -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1, -3, 789, 76, 900687, 1}; // TODO: Initialize to an appropriate value
            int[] arrExpected = { -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 789, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687, 900687}; // TODO: Initialize to an appropriate value
            const int SIZE = 100;
            int last = SIZE - 1; // TODO: Initialize to an appropriate value


            int[] actual = target.insertionSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for bubbleSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void bubbleSortTest3()
        {

            /*Description:tests to check if bubble function works
           * (Arguments)->return type: (void)->void
           *Precondition: actual main form and functions must exist
           * Postcondition:expected array and the actual returned array is checked to see if equal
           * Example(s): {9,8} passed, {8,9} is returned, the test passed*/

            // test with an already sorted array

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = {6,9,78,100,509,1089,4560,500000,600107}; // TODO: Initialize to an appropriate value
            int[] arrExpected = { 6, 9, 78, 100, 509, 1089, 4560, 500000, 600107 }; // TODO: Initialize to an appropriate value
            const int SIZE = 9;
            int last = SIZE - 1; // TODO: Initialize to an appropriate value


            int[] actual = target.insertionSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
