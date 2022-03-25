using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using Server.FormLogic;

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

            LoadedImageLogic testLoadedLogic = new LoadedImageLogic();

            string path = "..\\..\\..\\..\\COMP3404-Assignment2\\FishAssets\\JavaFish.png";

            testLoadedLogic.LoadNewImage(path);

            Image testBeforeImage = testLoadedLogic.GetImage(path);
            #endregion

            #region ACT
            Image testAfterImage = testDisplayLogic.RotateButton_Click(testBeforeImage);
            #endregion

            #region ASSERT
            Assert.AreNotEqual(testBeforeImage, testAfterImage);
            #endregion
        }
    }
}
