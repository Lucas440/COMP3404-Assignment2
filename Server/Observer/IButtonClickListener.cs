using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Lucas Brennan
/// DATE: 26/03/2022
/// </summary>
namespace Server.Observer
{
    /// <summary>
    /// An interface for classes that listen for a button click
    /// </summary>
    public interface IButtonClickListener
    {
        /// <summary>
        /// A method that responds to a button click event
        /// </summary>
        /// <param name="source">The object that caused the event</param>
        /// <param name="args">the event argument</param>
        void NewButtonClick(object source , ButtonClickArgs args);

        /// <summary>
        /// A method that responds to a button click event
        /// </summary>
        /// <param name="source">The object that caused the event</param>
        /// <param name="args">The event argument</param>
        /// <returns>The loaded image</returns>
        Image NewImageGet(object source, ButtonClickArgs args);
    }
}
