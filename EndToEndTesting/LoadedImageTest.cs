using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        public void TestLoadNewImage()
        {
        }
        /// <summary>
        /// This Method will test if the Class is storing the Images loaded
        /// it should store the images into a dictonary with a string as the key
        /// this test passes when the image is accessed from storage
        /// </summary>
        [TestMethod]
        public void TestImageStorage() { }
    }
}
