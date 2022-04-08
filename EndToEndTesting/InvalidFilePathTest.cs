using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Server.FormLogic;
using Server.Exceptions;
/// <summary>
/// Author Lucas Brennan
/// 
/// Date 25/03/2022
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// A Test class to test the InvalidFilePath Exception
    /// the class will test if the exception is being thrown
    /// The test passes when the Exception is thrown
    /// </summary>
    [TestClass]
    public class InvalidFilePathTest
    {
        /// <summary>
        /// A Test method that tests if the Exception is thrown
        /// This passes if the Exception is thrown
        /// </summary>
        [TestMethod]
        public void ExceptionCalledTest()
        {
            #region ARRANGE
            //DELCARES AND INTIALISE a new LoadedImagesLogic called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();
            //DECLARES a string called path which stores a incorrect path for an image
            string path = "..\\..\\..\\..\\COMP3404-Assignment2\\FishAssets\\Javaish.png";
            #endregion
            #region ACT
            try 
            {
                //Trys to load an image with path
                testLogic.LoadNewImage(path);

            #endregion
            #region ASSET

                //This is false as the Exception is not thrown
                Assert.IsTrue(false) ;
            }
            //Catches an InvalidFilePathException
            catch (InvalidFilePathException) 
            {
                //This is true as the Exception is thrown
                Assert.IsTrue(true);
            }
            #endregion
        }
    }
}
