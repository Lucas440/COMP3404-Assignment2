using System;
using System.Collections.Generic;
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
    /// An interface that publishes button clicks
    /// </summary>
    public interface IButtonClickPublisher
    {
        /// <summary>
        /// Subscribes a listener
        /// </summary>
        /// <param name="listener">The Listener being subscribed</param>
        void Subscribe(IButtonClickListener listener);
        /// <summary>
        /// UnSubscribes a Listener
        /// </summary>
        /// <param name="listener">The Listener being Unsubscribed</param>
        void UnSubscribe(IButtonClickListener listener);
    }
}
