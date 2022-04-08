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
        /// The Default Constructor
        /// </summary>
        public LoadedImages()
        {
            InitializeComponent();
            //INITALISE _UIDList
            _UIDList = new List<String>();
        }

        /// <summary>
        /// A Method that Initalises the Class
        /// </summary>
        /// <param name="pInvoker">A CommandInvoker</param>
        /// <param name="pAddImage">A ICommand used to AddImages</param>
        public void Initialise(ICommandInvoker pInvoker, ICommand pAddImage)
        {

            //INTIALISE Class variables
            //_commandInvoker
            _commandInvoker = pInvoker;
            //_addImageDisplay
            _addImageDisplay = pAddImage;


            // This process repeats for each image in the collection
            foreach (string ID in _UIDList)
            {
                // Create a new button
                Button button = new Button();

                // Load the image from the server
                //Image loadedImage = _server.GetImage(ID, _buttonWidth, _buttonHeight);

                // Set the size of the button
                //button.Height = loadedImage.Height;
                //button.Width = loadedImage.Width;

                // Show the image and the UID on the button
                //button.Image = loadedImage;
                button.Text = ID;

                // Set the Click method to the button's Click event 
                button.Click += ImageButton_Click;

                // Add the button to the menu
                ImageMenu.Controls.Add(button);
            }
        }

        /// <summary>
        /// A Method that responds to when the LoadNewImagesButton is Clicked
        /// </summary>
        /// <param name="sender">The Object that raised the event</param>
        /// <param name="e">The Event argument</param>
        private void LoadNewImageButton_Click(object sender, EventArgs e)
        {
            //Raises a new Event
            Image image = NewButtonClick(this , new ButtonClickArgs(){EventArgs = "LoadNewButton" });
            //Sets the Data in the command to the image returned by the event
            ((ICommandOneParam<Image>)_addImageDisplay).SetData = image;
            //Invokes _addImageDisplay
            _commandInvoker.Invoke(_addImageDisplay);
        }

        /// <summary>
        /// A Method that responds to when a ImageButton is clicked
        /// </summary>
        /// <param name="sender">The Object that raised the event</param>
        /// <param name="e">the event argument</param>
        private void ImageButton_Click(object sender, EventArgs e)
        {
            // Specify which button activated the event
            Button clicked = sender as Button;

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
