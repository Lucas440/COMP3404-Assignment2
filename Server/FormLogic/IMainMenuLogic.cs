using Server.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 11/03/22
/// </summary>
namespace Server.FormLogic
{
    public interface IMainMenuLogic : IFormLogic
    {
        /// <summary>
        /// A Method that Initalises IMainMenuLogic
        /// </summary>
        /// <param name="pInvoker">A Command Invoker used to Invoke Commands</param>
        /// <param name="pCommand">A Command to be Invoked</param>
        void Initalise(ICommandInvoker pInvoker, ICommand pCommand);

        /// <summary>
        /// A method used to react to when the NewNoteButton has been Clicked
        /// </summary>
        void NewNoteButtonClick();
    }
}
