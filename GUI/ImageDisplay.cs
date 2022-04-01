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
            _logic.Initialise(pImage);
            ImageHolder.Image = _logic.DisplayImage;

            BrightnessLabel.Text = BrightnessCounter.Value.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateButton_Click(object sender, EventArgs e)
        {
            ImageHolder.Image = _logic.RotateButton_Click();
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            ImageHolder.Image = _logic.FlipButton_Click("horizontal");
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            ImageHolder.Image = _logic.FlipButton_Click("vertical");
            ImageHolder.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBrightnessButton_Click(object sender, EventArgs e)
        {
            //_logic.ChangeButton_Click("brightness");
            
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
            //_logic.FilterButton_Click("photo negative");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SepiaToneFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("sepia");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlueScaleFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("bluescale");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GreyScaleFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("greyscale");
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

        private void BrightnessCounter_ValueChanged(object sender, EventArgs e)
        {
            _logic.ChangeButton_Click("brightness" , Convert.ToInt32( BrightnessCounter.Value));

            ImageHolder.Image = _logic.DisplayImage;
        }

        private void SaturationCounter_ValueChanged(object sender, EventArgs e)
        {
            _logic.ChangeButton_Click("saturation", (int)SaturationCounter.Value);

            ImageHolder.Image = _logic.DisplayImage;
        }
    }
}
