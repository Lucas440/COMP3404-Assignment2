using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.FormLogic;
using System;
using System.Drawing;

/// <summary>
/// AUTHOR: Lucas Brennan & Flynn Osborne
/// DATE: 21/04/2022
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This class tests the LoadedImageTest class 
    /// </summary>
    [TestClass]
    public class LoadedImageTest
    {
        /// <summary>
        /// This method will test the LoadNewImage method by loading a image from the disk
        /// The test will be passed if the image is loaded and can be accessed
        /// </summary>
        [TestMethod]
        public void TestLoadNewImageWithPath()
        {
            #region ARRANGE
            // SET a path for the image
            string path = "..\\..\\..\\..\\COMP3404-Assignment2-master\\FishAssets\\JavaFish.png";

            // INITIALISE a new ILoadedImage called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();

            // CALL LoadNewImage passing the image path
            testLogic.LoadNewImage(path);
            #endregion

            #region ACT
            // TEST if the image in the logic is null
            if (((LoadedImageLogic)testLogic).GetImage(path) != null)
            #endregion

            #region ASSERT
            {
                // PASS the test if the image is not null
                Assert.IsTrue(true);
            }
            else 
            {
                // FAIL the test if the image is null
                Assert.IsTrue(false);
            }
            #endregion
        }
        /// <summary>
        /// This method will test the LoadNewImage Method by trying to obtain an image without using a proper file path
        /// The test can be passed if an exception is thrown
        /// </summary>
        [TestMethod]
        public void TestLoadNewImageWithOutPath() 
        {
            #region ARRANGE
            // INITIALISE a new ILoadedImage called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();
            #endregion
            #region ACT
            try
            {
                // CALL the LoadNewImage method
                Image filePath = testLogic.GetImage("");
                Assert.IsTrue(false);

            }
            catch (Exception)
            {
                #endregion
            #region ASSERT
                Assert.IsTrue(true);

            }
            #endregion
        }
        /// <summary>
        /// This method will test if the class is storing the loaded images in the dictionary
        /// The test involves loading two images from the disk into the collection
        /// The test can be passed if the two images can be returned
        /// </summary>
        [TestMethod]
        public void TestImageStorage() 
        {
            #region ARRANGE
            // INITIALISE a new ILoadedImage called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();

            // SET a path for the first image
            string testPath1 = "..\\..\\..\\..\\COMP3404-Assignment2-master\\FishAssets\\JavaFish.png";
            // SET a path for the second image
            string testPath2 = "..\\..\\..\\..\\COMP3404-Assignment2-master\\FishAssets\\OrangeFish.png";

            // CALL LoadNewImage passing the first test path
            testLogic.LoadNewImage(testPath1);
            // CALL LoadNewImage passing the second test path
            testLogic.LoadNewImage(testPath2);
            #endregion
            #region ACT
            // TEST whether the images returned were null
            if (testLogic.GetImage(testPath1) != null && testLogic.GetImage(testPath2) != null)
            #endregion
            #region ASSERT
            {
                // PASS the test if the images were not null
                Assert.IsTrue(true);
            }
            else
            {
                // FAIL the test if the images were null
                Assert.IsTrue(false);
            }
            #endregion
        }
    }
}
