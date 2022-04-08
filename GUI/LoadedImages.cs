using Server.Command;
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
        // DECLARE a variable to hold a command invoker
        ICommandInvoker _commandInvoker;

        // DECLARE a variable to hold a command to add an ImageDisplay form
        ICommand _addImageDisplay;

        /// <summary>
        /// The constructor for the LoadedImages form
        /// </summary>
        public LoadedImages()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The method used to initialise the form
        /// </summary>
        /// <param name="pInvoker">A CommandInvoker</param>
        /// <param name="pAddImage">A ICommand used to AddImages</param>
        public void Initialise(ICommandInvoker pInvoker, ICommand pAddImage)
        {
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
            ((ICommandOneParam<Image>)_addImageDisplay).SetData = image;
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
