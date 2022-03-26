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
    /// An interface used to represent commands
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// A Method used to Execute the Command
        /// </summary>
        void Execute();
    }
}
