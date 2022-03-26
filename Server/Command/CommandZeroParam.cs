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
    /// A class used to represent commands with Zero Paramiters
    /// </summary>
    public class CommandZeroParam : ICommandZeroParam
    {
        //DECLARE a Action called _action
        private Action _action;
        /// <summary>
        /// A Property which is used to set the Action of the command
        /// </summary>
        public Action SetAction { set { _action = value; } }

        /// <summary>
        /// A method which Executes the command
        /// </summary>
        public void Execute() 
        {
            //Invokes _action
            _action.Invoke();
        }
    }
}
