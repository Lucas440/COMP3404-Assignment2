using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Lucas Brennan
/// DATE: 26/03/22
/// </summary>
namespace Server.Observer
{
    /// <summary>
    /// A class for the data sent during a ButtonClick event
    /// </summary>
    public class ButtonClickArgs
    {
        /// <summary>
        /// A property for the event arguments
        /// </summary>
        public string EventArgs { get; set; }
    }
}
