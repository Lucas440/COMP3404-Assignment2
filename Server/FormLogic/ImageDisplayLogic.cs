using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// AUTHOR: Lucas Brennan & Flynn Osborne
// DATE: 18/03/2022

namespace Server.FormLogic
{
    /// <summary>
    /// A class that represents the logic of the Image Display form
    /// </summary>
    public class ImageDisplayLogic : IImageDisplayLogic
    {
        public ImageDisplayLogic()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialise()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public Image RotateButton_Click(Image temp)
        {
            temp.RotateFlip(RotateFlipType.Rotate90FlipNone);

            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        public void FlipButton_Click(string option)
        {
            if (option == "vertical")
            {
                //temp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            else if (option == "horizontal")
            {
                //temp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        public void ChangeButton_Click(string option)
        {
            if (option == "brightness")
            {

            }
            else if (option == "contrast")
            {

            }
            else if (option == "saturation")
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        public void FilterButton_Click(string option)
        {
            if (option == "photo negative")
            {

            }
            else if (option == "sepia")
            {

            }
            else if (option == "greyscale")
            {

            }
            else if (option == "bluescale")
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveImageButton_Click()
        {

        }
    }
}
