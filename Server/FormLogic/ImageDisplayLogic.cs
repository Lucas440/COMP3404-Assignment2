using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

// AUTHOR: Lucas Brennan & Flynn Osborne
// DATE: 18/03/2022

namespace Server.FormLogic
{
    /// <summary>
    /// A class that represents the logic of the Image Display form
    /// </summary>
    public class ImageDisplayLogic : IImageDisplayLogic
    {
        //DECLARE a image called _imageDisplayed
        private Image _imageDisplayed;
        /// <summary>
        /// A Property used to get the image to be displayed
        /// </summary>
        public Image DisplayImage { get => _imageDisplayed; }

        public ImageDisplayLogic()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialise(Image pImage)
        {
            //Sets _imageDisplayed to pImage
            _imageDisplayed = pImage;
        }

        /// <summary>
        /// A Method used to roatate the image
        /// </summary>
        /// <param name="temp">the image being rotated</param>
        /// <returns></returns>
        public Image RotateButton_Click()
        {
            //Roatates the Image 90 Degrees
            _imageDisplayed.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //retruns the image
            return _imageDisplayed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        public Image FlipButton_Click(string option)
        {
            if (option == "vertical")
            {
                _imageDisplayed.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            else if (option == "horizontal")
            {
                _imageDisplayed.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            return _imageDisplayed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        public void ChangeButton_Click(string option , int pValue)
        {
            if (option == "brightness")
            {
                //
                float value = pValue * 0.01f;
                float[][] colorMatrixElements = {
                new float[] {1,0,0,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,1,0},
                new float[] {value,value,value,0,1}
            };

                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                
                //PictureBox1.Image
                Graphics _g = default(Graphics);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_imageDisplayed.Width), Convert.ToInt32(_imageDisplayed.Height));
                _g = Graphics.FromImage(bm_dest);
                _g.DrawImage(_imageDisplayed, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);

                _imageDisplayed = bm_dest;
                
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
