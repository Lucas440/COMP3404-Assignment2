﻿using Server.Command;
using Server.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// AUTHOR: Flynn Osborne & Lucas Brennan
// DATE: 18/03/2022

namespace GUI
{
    /// <summary>
    /// A Class used to display loaded images
    /// </summary>
    public partial class LoadedImages : Form , IButtonClickPublisher 
    {
        // Variables to dictate the size of each button
        private int _buttonWidth;
        private int _buttonHeight;

        // A variable to hold a list of all the unique IDs for images
        private IList<String> _UIDList;

        //DECLARE a ICommandInovker called _commandInvoker
        ICommandInvoker _commandInvoker;
        //DECLARE a ICommand called _addImageDisplay
        ICommand _addImageDisplay;

        /// <summary>
        /// The constructor for the LoadedImages form
        /// </summary>
        public LoadedImages()
        {
            InitializeComponent();

            //INITALISE _UIDList
            _UIDList = new List<String>();
        }

        /// <summary>
        /// The method used to initialise the form
        /// </summary>
        /// <param name="pInvoker">A CommandInvoker</param>
        /// <param name="pAddImage">A ICommand used to AddImages</param>
        public void Initialise(ICommandInvoker pInvoker, ICommand pAddImage)
        {

            //INTIALISE Class variables
            //_commandInvoker
            _commandInvoker = pInvoker;
            //_addImageDisplay

            // SET the command invoker
            _commandInvoker = pInvoker;

            // SET the AddImageDisplay command
            _addImageDisplay = pAddImage;
        }

        /// <summary>
        /// The method that loads a new image from computer to the software
        /// </summary>
        /// <param name="sender">The object that called the event</param>
        /// <param name="e">The event arguments</param>
        private void LoadNewImageButton_Click(object sender, EventArgs e)
        {
            // RAISE a new Event
            Image image = NewButtonClick(this , new ButtonClickArgs(){EventArgs = "LoadNewButton" });
            //Sets the Data in the command to the image returned by the event
            ((ICommandOneParam<Image>)_addImageDisplay).SetData = image;
            //Invokes _addImageDisplay
            _commandInvoker.Invoke(_addImageDisplay);

            // STORE the image in the collection
            AddImageToMenu(image);
        }

        /// <summary>
        /// This method stores a loaded image in the form's collection
        /// </summary>
        /// <param name="loadedImage">The image that is added to the collection</param>
        private void AddImageToMenu(Image loadedImage)
        {
            // CREATE a button to hold the image
            Button button = new Button();

            // SET the button to hold the image
            button.Height = loadedImage.Height;
            button.Width = loadedImage.Width;
            button.Image = loadedImage;

            // SET the ImageButton_Click method to the button's Click event 
            button.Click += ImageButton_Click;

            // ADD the button to the menu
            ImageMenu.Controls.Add(button);
        }

        /// <summary>
        /// This method loads an ImageDisplay form for an already loaded image
        /// </summary>
        /// <param name="sender">The button that called the method</param>
        /// <param name="e">The event arguments</param>

        private void ImageButton_Click(object sender, EventArgs e)
        {
            // SPECIFY which button activated the event
            Button clicked = sender as Button;

            // RAISE a new Event
            ((ICommandOneParam<Image>)_addImageDisplay).SetData = clicked.Image;
            _commandInvoker.Invoke(_addImageDisplay);

        }

        // ------------------------------------- IButtonClickPublisher Implementaion ------------------------------------------

        /// <summary>
        /// A Delegate for the event
        /// </summary>
        /// <param name="source">The soruce of the event</param>
        /// <param name="args">the event argument</param>
        public delegate Image ButtonClickHandler(object source, ButtonClickArgs args);

        //NewButtonClick is raised each time a button is clicked
        public event ButtonClickHandler NewButtonClick;

        /// <summary>
        /// Subscribes a listener
        /// </summary>
        /// <param name="listener">The Listener being subscribed</param>
        public void Subscribe(IButtonClickListener listener)
        {
            //Subscribes the Listeners NewButtonClick method to the event
            NewButtonClick += listener.NewImageGet;
        }
        /// <summary>
        /// UnSubscribes a Listener
        /// </summary>
        /// <param name="listener">The Listener being Unsubscribed</param>
        public void UnSubscribe(IButtonClickListener listener)
        {
            //UnSubscribes the Listeners NewButtonClick method to the event
            NewButtonClick += listener.NewImageGet;
        }


    }
}
