using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan
/// 
/// Date 26/03/22
/// </summary>
namespace Server.Observer
{
    /// <summary>
    /// The data sent during a ButtonClick event
    /// </summary>
    public class ButtonClickArgs
    {
        /// <summary>
        /// The event argument
        /// </summary>
        public string EventArgs { get; set; }
    }
}
