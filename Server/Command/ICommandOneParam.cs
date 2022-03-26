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
    /// A Interface that is used for commands with One Paramiter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommandOneParam<T> : ICommand
    {
        /// <summary>
        /// A Property used to set the data of the command
        /// </summary>
        T SetData { set; }
        /// <summary>
        /// A Property used to set the action of the command
        /// </summary>
        Action<T> SetAction { set; }
    }
}
