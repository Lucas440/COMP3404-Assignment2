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
    /// An interface used for commands with Zero paramiters
    /// </summary>
    public interface ICommandZeroParam : ICommand
    {
        /// <summary>
        /// A Property used to set the Action of the command
        /// </summary>
        Action SetAction { set; }
    }
}
