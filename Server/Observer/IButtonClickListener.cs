using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan
/// 
/// Date 26/03/2022
/// </summary>
namespace Server.Observer
{
    /// <summary>
    /// An interface that listens for a button click
    /// </summary>
    public interface IButtonClickListener
    {
        /// <summary>
        /// A Method that responds to a button click event
        /// </summary>
        /// <param name="source">The object that caused the event</param>
        /// <param name="args">the event argument</param>
        void NewButtonClick(object source , ButtonClickArgs args);

        /// <summary>
        /// A Method that responds to a button click event
        /// </summary>
        /// <param name="source">The object that caused the event</param>
        /// <param name="args">the event argument</param>
        /// <returns>An image loaded</returns>
        Image NewImageGet(object source, ButtonClickArgs args);
    }
}
