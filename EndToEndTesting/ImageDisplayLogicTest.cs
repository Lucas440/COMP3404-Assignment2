using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Drawing;
using Server.FormLogic;
using Server.Command;

/// <summary>
/// AUTHOR: Lucas Brennan & Flynn Osborne
/// DATE: 21/04/2022
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This class tests the ImageDisplayLogic class
    /// </summary>
    [TestClass]
    public class ImageDisplayLogicTest
    {
        /// <summary>
        /// This method will test the OnButtonClick method
        /// The method should cause an effect on the image provided
        /// The test will pass if the correct response is given
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
            string path = "..\\..\\..\\..\\COMP3404-Assignment2-master\\FishAssets\\JavaFish.png";

            // LOAD the image from the given path
            testLoadedLogic.LoadNewImage(path);

            // SET the image to a variable
            Image testBeforeImage = testLoadedLogic.GetImage(path);

            // INITIALISE the logic passing a clone of the image, a new command and a commandinvoker
            testDisplayLogic.Initialise((Image)testBeforeImage.Clone() , new CommandZeroParam() , new CommandInvoker());

            #endregion

            #region ACT
            // ACTIVATE the RotateButton_Click event
            testDisplayLogic.RotateButton_Click();
            #endregion

            #region ASSERT
            // TEST if the Rotate command has worked
            if (testBeforeImage != testDisplayLogic.DisplayImage) 
            {
                // PASS the test if the images are different
                Assert.IsTrue(true);
            }
            else 
            {
                // FAIL the test if the images are the same
                Assert.IsTrue(false);
            }
            #endregion
        }
    }
}
