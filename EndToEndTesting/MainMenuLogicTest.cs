using COMP3404;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server.Command;
using Server.FormLogic;
using System;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 04/03/22
/// </summary>
namespace EndToEndTesting
{
    /// <summary>
    /// This will test the MainMenuLogic class 
    /// The test run on this class will ensure the NewNoteButtonClick creates a new object correctly
    /// </summary>
    [TestClass]
    public class MainMenuLogicTest
    {
        /// <summary>
        /// This method will test the NewNoteButtonClick method
        /// it should create a new note which will be stored inside of it
        /// This test passes if the note is created without error
        /// </summary>
        [TestMethod]
        public void TestNewNoteButtonClick()
        {
            #region ARRANGE
            //INTIALISE a new IMainMenuLogic called testLogic
            IMainMenuLogic testLogic = new MainMenuLogic();

            //INTIALISE a Mock Command Invoker
            var mockCommandInvoker = new Mock<ICommandInvoker>();
            //INTIALISE a Mock Command
            var mockCommand = new Mock<ICommand>();

            //Sets up mockCommand with the Exectue Method
            mockCommand.Setup(mock => mock.Execute());

            //Sets up mockCommandInvoker with mockCommand passed into it
            mockCommandInvoker.Setup(mock => mock.Invoke(mockCommand.Object));
            //Initalises test logic
            testLogic.Initalise(mockCommandInvoker.Object , mockCommand.Object);
            //INTIALSE a bool called hasPassed
            bool hasPassed = true;
            #endregion
            #region ACT
            //Calls NewNoteButtonClick
            testLogic.NewNoteButtonClick();
            #endregion
            #region ASSERT
            //trys the following code
            try 
            {
                //Verifys the command has been invoked Once
                mockCommandInvoker.Verify(mock => mock.Invoke(mockCommand.Object) , Times.Once());
            } 
            //Catches any exception
            catch (Exception) 
            {
                //hasPassed is set to false
                hasPassed = false;
            } 
            finally 
            {
                //gives a test result depending on if hasPassed is true or false
                Assert.IsTrue(hasPassed);
            }
            #endregion
        }
    }
}
