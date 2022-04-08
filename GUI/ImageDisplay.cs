using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Command;
using Server.FormLogic;

// AUTHOR: Flynn Osborne && Lucas Brennan
// DATE: 01/04/2022

namespace GUI
{
    /// <summary>
    /// A Class used to Display Images
    /// </summary>
    public partial class ImageDisplay : Form
    {
        // DECLARE a IImageDisplayLogic called _logic
        private IImageDisplayLogic _logic;



        /// <summary>
        /// The Default Constructor
        /// </summary>
        public ImageDisplay()
        {
            InitializeComponent();
            //INTALISES _logic
            _logic = new ImageDisplayLogic();
        }
        /// <summary>
        /// A Method used to Initalise the Display
        /// </summary>
        /// <param name="pImage">The Image being displayed</param>

        public void Intialise(Image pImage , ICommand pSaveCommand , ICommandInvoker pInvoker) 
        {
            //Intialises _logic
            _logic.Initialise(pImage , pSaveCommand , pInvoker);
            //Sets Image in Imageholder to what is in _logic
            ImageHolder.Image = _logic.DisplayImage;

        }

        /// <summary>
        /// A method that responds to a button click on RotateButton_Click
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event argument</param>
        private void RotateButton_Click(object sender, EventArgs e)
        {
            //Calls RotateButton in the logic
            _logic.RotateButton_Click();
            //Sets the displayed image to what is in the logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the image holder
            ImageHolder.Focus();
        }
        /// <summary>
        /// A method that responds to a Button click on FlipHorizontalButton
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event argument</param>
        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            //Calls FlipButton_Click
            _logic.FlipButton_Click("horizontal");
            //Sets the displayed image to what is in the logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the image holder
            ImageHolder.Focus();
        }

        /// <summary>
        /// A method that responds to a flip button click
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event argument</param>
        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            //Sets the Image to what is returned from logic
            _logic.FlipButton_Click("vertical");
            //Sets the displayed image to what is in the logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the image Holder
            ImageHolder.Focus();
        }
        /// <summary>
        /// A method that responds to When the photo negative button is clicked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">the event argument</param>
        private void PhotoNegativeFilterButton_Click(object sender, EventArgs e)
        {
            //Calls FilterButton_Click passing "photo negative"
            _logic.FilterButton_Click("photo negative");
            //Sets the image in the Display to the image stored in the logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the ImageHolder
            ImageHolder.Focus();
        }

        /// <summary>
        /// A method that responds to When the Sepia button is clicked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">the event argument</param>
        private void SepiaToneFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("sepia");
            //Sets the image in the Display to the image stored in the logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the ImageHolder
            ImageHolder.Focus();
        }

        /// <summary>
        /// A method that responds to When the Blue Scale button is clicked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">the event argument</param>
        private void BlueScaleFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("bluescale");
            //Sets the image in the Display to the image stored in the logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the ImageHolder
            ImageHolder.Focus();
        }

        /// <summary>
        /// A method that responds to When the GreyScale button is clicked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">the event argument</param>
        private void GreyScaleFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("greyscale");
            //Sets the image in the Display to the image stored in the logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the ImageHolder
            ImageHolder.Focus();
        }

        /// <summary>
        /// A method that responds to When the Save button is clicked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">the event argument</param>
        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            //Calls the SaveImageButton method
            _logic.SaveImageButton_Click();
        }
        /// <summary>
        /// A method that responds to a value change on the brightness counter
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event argument</param>
        private void BrightnessCounter_ValueChanged(object sender, EventArgs e)
        {
            //Calls ChangeButton_Click in _logic
            _logic.ChangeButton_Click("brightness" , Convert.ToInt32( BrightnessCounter.Value));
            //Sets the Displayed image to the image in _logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the image holder
            ImageHolder.Focus();
        }
        /// <summary>
        /// A method that responds to a value change on the Saturation counter
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event argument</param>
        private void SaturationCounter_ValueChanged(object sender, EventArgs e)
        {
            //Calls ChangeButton_Click in _logic
            _logic.ChangeButton_Click("saturation", (int)SaturationCounter.Value);
            //Sets the Displayed image to the image in _logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to the image holder
            ImageHolder.Focus();
        }
        /// <summary>
        /// A Method that responds to when the Contrast Counter Value changes
        /// </summary>
        /// <param name="sender">The Object that sent the event</param>
        /// <param name="e">The event argument</param>
        private void ContrastCounter_ValueChanged(object sender, EventArgs e)
        {
            //Calls the ChangeButton_Click method passing contrast and the value of the counter
            _logic.ChangeButton_Click("contrast", (int)ContrastCounter.Value);
            //Sets the image in the holder to the image in _logic
            ImageHolder.Image = _logic.DisplayImage;
            //Draws focus to imageholder
            ImageHolder.Focus();
        }
    }
}
