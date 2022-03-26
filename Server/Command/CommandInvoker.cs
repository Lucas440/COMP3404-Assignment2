using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan
/// 
/// Date: 04/03/22
/// </summary>
namespace Server.Command
{
    /// <summary>
    /// A class used to invoke commands
    /// </summary>
    public class CommandInvoker : ICommandInvoker
    {
        /// <summary>
        /// A method used to invoke commands
        /// </summary>
        /// <param name="pCommand">The command being invoked</param>
        public void Invoke(ICommand pCommand) 
        {
            //Executes the command
            pCommand.Execute();
        }
    }
}
