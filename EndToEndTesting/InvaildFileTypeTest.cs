using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Exceptions;
using Server.FormLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace EndToEndTesting
{
    /// <summary>
    /// A Test class used to Test the InvalidFileType Exception
    /// </summary>
    [TestClass]
    public class InvaildFileTypeTest
    {

        /// <summary>
        /// This method tests if the InvalidFileType Exception is thrown when a incorrect file type is loaded into the 
        /// LoadedImageLogic
        /// this test will pass if the Exception is thrown
        /// </summary>
        [TestMethod]
        public void TestIfExceptionIsThrown()
        {
            #region ARRANGE
            //DECLARES and INITALISES a new ILoadedImageLogic called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();
            #endregion
            #region ACT
            try 
            {
                //Calls LoadNewImage in testLogic
                testLogic.LoadNewImage();

            #endregion
            #region ASSERT
                //Fails the test as the Exception is not called
                Assert.IsTrue(false);
            }
            catch (InvalidFileTypeException) 
            {
                //Passes the test
                Assert.IsTrue(true);
            }
            #endregion
        }
    }
}
