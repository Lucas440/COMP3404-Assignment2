using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Drawing;
using Server.FormLogic;
using Server.Command;

/// <summary>
/// AUTHOR: Lucas Brennan & Flynn Osborne
/// DATE: 25/03/22
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This test the ImageDisplayLogic class
    /// This test will ensure the OnButtonClick method functions correctly with the event given
    /// </summary>
    [TestClass]
    public class ImageDisplayLogicTest
    {
        /// <summary>
        /// This method will Test the OnButtonClick method
        /// It should respond to the event Args that is given to it
        /// This test passess when the correct response is given
        /// </summary>
        [TestMethod]
        public void TestOnButtonClick()
        {
            #region ARRANGE
            // INSTANTIATE a test ImageDisplayLogic instance
            ImageDisplayLogic testDisplayLogic = new ImageDisplayLogic();

            // INSTANTIATE a test LoadedImageLogic instance
            LoadedImageLogic testLoadedLogic = new LoadedImageLogic();

            // GET the path to an image
            string path = "..\\..\\..\\..\\COMP3404-Assignment2\\FishAssets\\JavaFish.png";

            // LOAD the image from the given path
            testLoadedLogic.LoadNewImage(path);

            // SET the image to a variable
            Image testBeforeImage = testLoadedLogic.GetImage(path);

            //Initalises the Logic passing a clone of the image, a new command and commandinvoker
            testDisplayLogic.Initialise((Image)testBeforeImage.Clone() , new CommandZeroParam() , new CommandInvoker());

            #endregion

            #region ACT
            // ACTIVATE the RotateButton_Click event
            testDisplayLogic.RotateButton_Click();
            #endregion

            #region ASSERT
            //If the images are different this is true
            if (testBeforeImage != testDisplayLogic.DisplayImage) 
            {
                //the test passes
                Assert.IsTrue(true);
            }
            else 
            {
                //the test fails
                Assert.IsTrue(false);
            }
            #endregion
        }
    }
}
