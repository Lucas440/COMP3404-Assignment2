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
    /// A Class used for commands with One Paramiter
    /// </summary>
    /// <typeparam name="T">The Type of Data in the Command</typeparam>
    public class CommandOneParam<T> : ICommandOneParam<T>
    {
        //DECLARE an Action<T> called _action
        private Action<T> _action;

        //DECLARE a type T called _data
        private T _data;

        /// <summary>
        /// A Property used to set the data of the command
        /// </summary>
        public T SetData { set { _data = value; } }
        /// <summary>
        /// A Property used to set the action of the command
        /// </summary>
        public Action<T> SetAction { set { _action = value; } }

        /// <summary>
        /// A method which Executes the command
        /// </summary>
        public void Execute()
        {
            //Invokes _action
            _action.Invoke(_data);
        }
    }
}
