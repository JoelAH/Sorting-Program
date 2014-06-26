using Sorting_Program;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MainTestProject
{


    /// <summary>
    ///This is a test class for MainTestFile and is intended
    ///to contain all MainTestFile Unit Tests
    ///</summary>
    [TestClass()]
    public class MainTestFile
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
            /*Description:tests to check if insertion function works
            * (Arguments)->return type: (void)->void
            *Precondition: actual main form and functions must exist
            * Postcondition:expected array and the actual returned array is checked to see if equal
            * Example(s): {9,8} passed, {8,9} is returned, the test passed*/


            // test with a mixture of positive and negative

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = {-3,-9,7,78,-90,300}; // TODO: Initialize to an appropriate value
            int[] arrExpected = {-90,-9,-3,7,78,300}; // TODO: Initialize to an appropriate value
            const int SIZE = 6;
            int last = SIZE-1; // TODO: Initialize to an appropriate value
            

            int[] actual = target.insertionSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for insertionSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void insertionSortTest2()
        {
            /*Description:tests to check if insertion function works
            * (Arguments)->return type: (void)->void
            *Precondition: actual main form and functions must exist
            * Postcondition:expected array and the actual returned array is checked to see if equal
            * Example(s): {9,8} passed, {8,9} is returned, the test passed*/


            // test with huge values that are close

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = {1958322,78101,1000,2000567,11346,10000,5000000}; // TODO: Initialize to an appropriate value
            int[] arrExpected = { 1000,10000,11346,78101,1958322,2000567,5000000}; // TODO: Initialize to an appropriate value
            const int SIZE = 7;
            int last = SIZE - 1; // TODO: Initialize to an appropriate value


            int[] actual = target.insertionSort(arr, last);

            for (int i = 0; i < SIZE; i++)
            {
                Assert.AreEqual(arrExpected[i], actual[i]);
            }

            // Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for insertionSort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sorting Program.exe")]

        public void insertionSortTest3()
        {
            /*Description:tests to check if insertion function works
            * (Arguments)->return type: (void)->void
            *Precondition: actual main form and functions must exist
            * Postcondition:expected array and the actual returned array is checked to see if equal
            * Example(s): {9,8} passed, {8,9} is returned, the test passed*/


            // test empty array

            frmMain_Accessor target = new frmMain_Accessor(); // TODO: Initialize to an appropriate value
            int[] arr = {}; // TODO: Initialize to an appropriate value
            int[] arrExpected = {}; // TODO: Initialize to an appropriate value
            const int SIZE = 0;
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