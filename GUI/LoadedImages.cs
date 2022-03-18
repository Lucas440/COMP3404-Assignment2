using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// AUTHOR: Flynn Osborne
// DATE: 18/03/2022

namespace GUI
{
    public partial class LoadedImages : Form
    {
        //
        private ImageDisplay _imageDisplay;

        // Variables to dictate the size of each button
        private int _buttonWidth;
        private int _buttonHeight;

        // A variable to hold a list of all the unique IDs for images
        private IList<String> _UIDList;

        // A varaible to hold the server
        //private IServer _server;

        //private ILoadedImageLogic _logic;

        /// <summary>
        /// 
        /// </summary>
        public LoadedImages()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialise()
        {
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadNewImageButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageButton_Click(object sender, EventArgs e)
        {
            // Specify which button activated the event
            Button clicked = sender as Button;

            // Create a new ImageViewer form and show it to the screen
            //_imageDisplay = new ImageDisplay(_server, clicked.Text);
            _imageDisplay.Show();
        }
    }
}
