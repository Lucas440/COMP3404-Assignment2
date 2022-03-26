using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Server.FormLogic;
using Server.Command;
using Server.Observer;

// AUTHOR: Flynn Osborne
// DATE: 18/03/2022

namespace GUI
{
    public partial class MainMenu : Form, IButtonClickPublisher 
    {
        /// <summary>
        /// 
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            //Raises a new Event
            NewButtonClick(this, new ButtonClickArgs() { EventArgs = sender.ToString() });
        }

        // ------------------------------------- IButtonClickPublisher Implementaion ------------------------------------------

        /// <summary>
        /// A Delegate for the event
        /// </summary>
        /// <param name="source">The soruce of the event</param>
        /// <param name="args">the event argument</param>
        public delegate void ButtonClickHandler(object source , ButtonClickArgs args);

        //NewButtonClick is raised each time a button is clicked
        public event ButtonClickHandler NewButtonClick;

        /// <summary>
        /// Subscribes a listener
        /// </summary>
        /// <param name="listener">The Listener being subscribed</param>
        public void Subscribe(IButtonClickListener listener) 
        {
            //Subscribes the Listeners NewButtonClick method to the event
            NewButtonClick += listener.NewButtonClick;
        }
        /// <summary>
        /// UnSubscribes a Listener
        /// </summary>
        /// <param name="listener">The Listener being Unsubscribed</param>
        public void UnSubscribe(IButtonClickListener listener) 
        {
            //UnSubscribes the Listeners NewButtonClick method to the event
            NewButtonClick += listener.NewButtonClick;
        }


    }
}
