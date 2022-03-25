using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using COMP3404;
using Server.Command;
using Server.ServiceLocator;

/// <summary>
/// AUTHOR: Lucas Brennan & Flynn Osborne
/// DATE: 25/03/22
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This class tests the controller 
    /// The test will ensure the contstructor is intialising the objects correctly
    /// The test will ensure the AddDisplay method is functioning correctly
    /// </summary>
    [TestClass]
    public class ControllerTest
    {
        /// <summary>
        /// This method will test controllers constructor
        /// It should Intialise and store objects
        /// this test passes when the constructor stores all objects needed
        /// </summary>
        [TestMethod]
        public void TestConstructor()
        {
            #region ARRANGE
            // CREATE a new test controller
            Controller testController = new Controller();

            // INSTANTIATE a test ServiceLocator and a new CommandInvoker
            IServiceLocator testLocator = new ServiceLocator();
            ICommandInvoker testInvoker = new CommandInvoker();
            #endregion

            #region ACT
            // INITIALISE the controller
            testController.Initalise(testLocator, testInvoker);
            #endregion

            #region ASSERT
            // ASSERT that the service locator and command invoker variables are not null
            Assert.IsNotNull(testController._serviceLocator);
            Assert.IsNotNull(testController._commandInvoker);
            #endregion
        }
        /// <summary>
        /// This method will test controllers AddDisplay method
        /// It should create a new Mock object
        /// This tests passes when a Mock Object is created
        /// </summary>
        [TestMethod]
        public void TestAddDisplay()
        {
            #region ARRANGE

            #endregion

            #region ACT

            #endregion

            #region ASSERT

            #endregion
        }
    }
}
