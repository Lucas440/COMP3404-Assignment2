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

// AUTHOR: Flynn Osborne
// DATE: 18/03/2022

namespace GUI
{
    public partial class ImageDisplay : Form
    {
        //
        private IImageDisplayLogic _logic;

        Image displayedImage;

        /// <summary>
        /// 
        /// </summary>
        public ImageDisplay()
        {
            InitializeComponent();

            _logic = new ImageDisplayLogic();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateButton_Click(object sender, EventArgs e)
        {
            _logic.RotateButton_Click(displayedImage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            _logic.FlipButton_Click("horizontal");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            _logic.FlipButton_Click("vertical");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBrightnessButton_Click(object sender, EventArgs e)
        {
            _logic.ChangeButton_Click("brightness");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeContrastButton_Click(object sender, EventArgs e)
        {
            _logic.ChangeButton_Click("contrast");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSaturationButton_Click(object sender, EventArgs e)
        {
            _logic.ChangeButton_Click("saturation");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhotoNegativeFilterButton_Click(object sender, EventArgs e)
        {
            _logic.FilterButton_Click("photo negative");
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
    }
}
