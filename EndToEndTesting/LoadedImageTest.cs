using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.FormLogic;
using System;
using System.Drawing;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 04/03/22
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This tests the LoadedImageTest class 
    /// The test will ensure The Dictonary is storing the images
    /// the LoadNewImage method is working correctly
    /// </summary>
    [TestClass]
    public class LoadedImageTest
    {
        /// <summary>
        /// This method will test the LoadNewImage Method
        /// it should load a image from the disk
        /// This test passes when the image is loaded and can be accessed
        /// </summary>
        [TestMethod]
        public void TestLoadNewImageWithPath()
        {
            #region ARRANGE
            //sets a path for the image
            string path = "..\\..\\..\\..\\COMP3404-Assignment2\\FishAssets\\JavaFish.png";

            //INITALISE a new ILoadedImage called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();
            //Calls LoadNewImage passing the path
            testLogic.LoadNewImage(path);
            #endregion

            #region ACT
            //If the returned image in test logic is not null
            if (((LoadedImageLogic)testLogic).GetImage(path) != null)
            #endregion

            #region ASSERT
            {
                //Passes the test
                Assert.IsTrue(true);
            }
            else 
            {
                //Fails the test
                Assert.IsTrue(false);
            }
            #endregion
        }
        /// <summary>
        /// This method will test the LoadNewImage Method
        /// it should load a image from the disk by giving the user a dialog
        /// This test passes when the image is loaded and can be accessed
        /// </summary>
        [TestMethod]
        public void TestLoadNewImageWithOutPath() 
        {
            #region ARRANGE
            //INITALISE a new ILoadedImage called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();
            #endregion
            #region ACT
            try
            {
                //Calls the LoadNewImage Method
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
        /// This Method will test if the Class is storing the Images loaded
        /// it should store the images into a dictonary with a string as the key
        /// this test passes when the image is accessed from storage
        /// </summary>
        [TestMethod]
        public void TestImageStorage() 
        {
            #region ARRANGE
            //INITALISE a new ILoadedImage called testLogic
            ILoadedImageLogic testLogic = new LoadedImageLogic();
            //sets a path for a image
            string testPath1 = "..\\..\\..\\..\\COMP3404-Assignment2\\FishAssets\\JavaFish.png";
            //sets a path for a image
            string testPath2 = "..\\..\\..\\..\\COMP3404-Assignment2\\FishAssets\\OrangeFish.png";

            //Calls LoadNewImage passing the first test path
            testLogic.LoadNewImage(testPath1);
            //Calls LoadNewImage passing the second test path
            testLogic.LoadNewImage(testPath2);
            #endregion
            #region ACT
            //If the images returned are not null this is true
            if (testLogic.GetImage(testPath1) != null && testLogic.GetImage(testPath2) != null)
            #endregion
            #region ASSERT
            {
                //Passes the test
                Assert.IsTrue(true);
            }
            else
            {
                //Fails the test
                Assert.IsTrue(false);
            }
            #endregion
        }
    }
}
