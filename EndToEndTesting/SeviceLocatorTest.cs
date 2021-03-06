using COMP3404;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server.ServiceLocator;
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
            #region Arrange
            //INTIALISE a new ServiceLocator called serviceLocator
            IServiceLocator serviceLocator = new ServiceLocator();

            //Initalise a mockController using the ServiceLocator to get the controller
            var mockController = (serviceLocator.Get<Mock<Controller>, Mock<Controller>>() as IFactory).Get<Mock<Controller>, Mock<Controller>>();

            //INITALISE a bool called hasPassed, Set to true
            bool hasPassed = true;
            #endregion
            #region ACT
            //Try the following code
            try
            {
                //Verify the mockController
                mockController.Verify();
            }
            //Catch any Exception
            catch(Exception) 
            {
                //Set hasPassed to false
                hasPassed = false;
            }
            #endregion
            #region ASSERT
            finally
            {
                //Assert hasPassed
                Assert.IsTrue(hasPassed);
            }
            #endregion
        }

        /// <summary>
        /// This test will be done by calling the Get Method
        /// by doing this it will store a facotry in a dictonary
        /// when this is done we should call it again and check if a new factory has been made
        /// or it stored the old factory
        /// If it uses a stored factory the test passes
        /// </summary>
        [TestMethod]
        public void TestServiceLocatorStore() 
        {
            #region ARRANGE
            //INTIALISE a new ServiceLocator called serviceLocator
            IServiceLocator serviceLocator = new ServiceLocator();

            //INITALISE a mockService using the service locator
            var mockService = (serviceLocator.Get<Mock<IService>, Mock<Factory>>());
            //INTIALISE a bool hasPassed set to true
            bool hasPassed = true;
            #endregion
            #region ACT
            //If mockSerivce is equal to the service got by ServiceLocator this is true
            if (!(mockService == serviceLocator.Get<Mock<IService> , Mock<Factory>>()))
            #endregion
            #region ASSERT
            {
                hasPassed = false;
            }
            //Assert a test result based on hasPassed
            Assert.IsTrue(hasPassed);

            #endregion
        }
    }
}
