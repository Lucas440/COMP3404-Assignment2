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
    /// A interface that is used to invoke commands
    /// </summary>
    public interface ICommandInvoker
    {
        /// <summary>
        /// A method used to invoke commands
        /// </summary>
        /// <param name="pCommand">The command being invoked</param>
        void Invoker(ICommand pCommand);
    }
}
