using Server.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 04/03/22
/// </summary>
namespace Server.FormLogic
{
    /// <summary>
    /// A Class used to handle the logic of MainMenu
    /// </summary>
    public class MainMenuLogic : IMainMenuLogic
    {
        //DECLARE a new ICommandInvoker called _commandInvoker
        ICommandInvoker _commandInvoker;
        //DECLARE a new ICommand called _command
        ICommand _command;

        /// <summary>
        /// A Method that Initalises MainMenuLogic
        /// </summary>
        /// <param name="pInvoker">A Command Invoker used to Invoke Commands</param>
        /// <param name="pCommand">A Command to be Invoked</param>
        public void Initalise(ICommandInvoker pInvoker , ICommand pCommand) 
        {
            //INTIALISE varibales
            //_commandInvoker
            _commandInvoker = pInvoker;
            //_command
            _command = pCommand;
        }
        /// <summary>
        /// A method used to react to when the NewNoteButton has been Clicked
        /// </summary>
        public void NewNoteButtonClick() 
        {
            _commandInvoker.Invoke(_command);
        }
    }
}
