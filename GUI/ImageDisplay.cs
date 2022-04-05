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

using Server.FormLogic;

// AUTHOR: Flynn Osborne
// DATE: 01/04/2022

namespace GUI
{
    public partial class ImageDisplay : Form
    {
        //
        private IImageDisplayLogic _logic;

        /// <summary>
        /// 
        /// </summary>
        public ImageDisplay()
        {
            InitializeComponent();

            _logic = new ImageDisplayLogic();
        }
        /// <summary>
        /// A Method used to Initalise the Display
        /// </summary>
        /// <param name="pImage">The Image being displayed</param>

        public void Intialise(Image pImage) 
        {
            //Intialises _logic
            _logic.Initialise(pImage);
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
            //Sets the displayed image to what is returned
            ImageHolder.Image = _logic.RotateButton_Click();
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
            //Sets the displayed imaged to what is returned
            ImageHolder.Image = _logic.FlipButton_Click("horizontal");
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
            ImageHolder.Image = _logic.FlipButton_Click("vertical");
            //Draws focus to the image Holder
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeContrastButton_Click(object sender, EventArgs e)
        {
           // _logic.ChangeButton_Click("contrast");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhotoNegativeFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("photo negative");
            ImageHolder.Image = _logic.DisplayImage;
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SepiaToneFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("sepia");
            ImageHolder.Image = _logic.DisplayImage;
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlueScaleFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("bluescale");
            ImageHolder.Image = _logic.DisplayImage;
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GreyScaleFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("greyscale");
            ImageHolder.Image = _logic.DisplayImage;
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveImageButton_Click(object sender, EventArgs e)
        {
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
            _logic.ChangeButton_Click("contrast", (int)ContrastCounter.Value);
            ImageHolder.Image = _logic.DisplayImage;
            ImageHolder.Focus();
        }
    }
}
