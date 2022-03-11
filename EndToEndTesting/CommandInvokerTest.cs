using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server.Command;
using System;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 04/03/22
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This class will test the CommandInvoker
    /// This ensure the CommandInovker is able to invoker the command that is given to it
    /// </summary>
    [TestClass]
    public class CommandInvokerTest
    {
        /// <summary>
        /// This method tests the Invoke command
        /// This should call a method on a Mock class
        /// This test passes when the Mock method has been called Once
        /// </summary>
        [TestMethod]
        public void TestInvoke()
        {
            #region ARRANGE
            //INITALSE a new ICommandInvoker called testInvoker
            ICommandInvoker testInvoker = new CommandInvoker();
            //INITALSE a mock ICommand 
            var mockCommand = new Mock<ICommand>();
            //Sets up the Exectue command in mockCommand
            mockCommand.Setup(mock => mock.Execute());
            //INTIALSE a bool called hasPassed set to true
            bool hasPassed = true;
            #endregion
            #region ACT
            //Invokes mockCommand
            testInvoker.Invoke(mockCommand.Object);

            #endregion
            #region ASSERT

            //trys the following
            try
            {
                mockCommand.Verify(mock => mock.Execute(), Times.Once());
            }
            //Catches any exception
            catch (Exception) 
            {
                //sets hasPassed to false
                hasPassed = false;
            }
            finally 
            {
                //Asserts a result bassed on hasPassed
                Assert.IsTrue(hasPassed);
            }
            #endregion
        }
    }
}
