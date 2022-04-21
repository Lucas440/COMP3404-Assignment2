using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Exceptions;
using Server.FormLogic;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// AUTHOR: Lucas Brennan
/// DATE: 21/04/2022
/// </summary>

namespace EndToEndTesting
{
    /// <summary>
    /// A Test class used to test the InvalidFileType exception
    /// </summary>
    [TestClass]
    public class InvaildFileTypeTest
    {

        /// <summary>
        /// This method tests whether the InvalidFileType Exception is thrown when a file of an incorrect type is loaded.
        /// The test will pass if the exception is thrown.
        /// 
        /// NOTE: To pass the test, the tester must select a file that is not a .png.
        /// </summary>
        [TestMethod]
        public void TestIfExceptionIsThrown()
        {

            #region ARRANGE
            // DECLARE and INITIALISE a new ILoadedImageLogic called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();
            #endregion
            #region ACT
            try 
            {
                // CALL LoadNewImage in testLogic
                testLogic.LoadNewImage();

            #endregion
            #region ASSERT
                // FAIL the test if the exception is not called
                Assert.IsTrue(false);
            }
            catch (InvalidFileTypeException) 
            {
                // PASS the test if the exception was called
                Assert.IsTrue(true);
            }
            #endregion
        }
    }
}
