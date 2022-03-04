using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 04/03/22
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This is used to test the service locator class
    /// The tests that will be ran on the class are 
    /// ensure the Get<T> method returns an object
    /// ensure the IDictonary is storing the objects after they have been made
    /// </summary>
    [TestClass]
    public class SeviceLocatorTest
    {
        /// <summary>
        /// This will test the Get Method
        /// it should return a factory which allows the test class to create a mock object using it
        /// if the object is created then the test passess
        /// </summary>
        [TestMethod]
        public void TestServiceLocatorGet()
        {
            //
            // TODO: Add test logic here
            //
        }
        /// <summary>
        /// This test will be done by calling the Get Method
        /// by doing this it will store a facotry in a dictonary
        /// when this is done we should call it again and check if a new factory has been made
        /// or it stored the old factory
        /// If it uses a stored factory the test passes
        /// </summary>
        [TestMethod]
        public void TestServiceLocatorStore() { }
    }
}
