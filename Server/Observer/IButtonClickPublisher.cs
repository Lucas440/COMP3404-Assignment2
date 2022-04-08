using System;
using System.Collections.Generic;
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
    /// An interface for classes that publish button clicks
    /// </summary>
    public interface IButtonClickPublisher
    {
        /// <summary>
        /// A method to subscribe a listener
        /// </summary>
        /// <param name="listener">The listener being subscribed</param>
        void Subscribe(IButtonClickListener listener);

        /// <summary>
        /// A method to unsubscribe a listener
        /// </summary>
        /// <param name="listener">The listener being unsubscribed</param>
        void UnSubscribe(IButtonClickListener listener);
    }
}
