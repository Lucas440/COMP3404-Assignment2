using Server.Command;
using System;
using System.Drawing;
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
        //DECLARE a ICommand called _saveImage
        private ICommand _saveImage;
        //DECLARE a ICommandInvoker called _commandInvoker
        private ICommandInvoker _commandInvoker;

        /// <summary>
        /// A Property used to get the image to be displayed
        /// </summary>
        public Image DisplayImage { get => _imageDisplayed; }
        /// <summary>
        /// The Default Constructor
        /// </summary>
        public ImageDisplayLogic()
        {

        }

        /// <summary>
        /// A Method used to intialise the Logic
        /// </summary>
        public void Initialise(Image pImage , ICommand pSaveCommand, ICommandInvoker pInvoker)
        {
            //Sets _imageDisplayed to pImage
            _imageDisplayed = pImage;
            //INTALISES class variables
            //_saveImage
            _saveImage = pSaveCommand;
            //_commandInvoker
            _commandInvoker = pInvoker;
        }

        /// <summary>
        /// A Method used to roatate the image
        /// </summary>
        public void RotateButton_Click()
        {
            //Roatates the Image 90 Degrees
            _imageDisplayed.RotateFlip(RotateFlipType.Rotate90FlipNone);
            
        }

        /// <summary>
        /// A Method used to Flip images
        /// </summary>
        /// <param name="option">The option the image is being flipped (Virtical or Horizontal)</param>
        public void FlipButton_Click(string option)
        {
            //If the vertical Button is clicked 
            if (option == "vertical")
            {
                //Flips the Image on the Y axis
                _imageDisplayed.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            //If the horizontal Button is clicked 
            else if (option == "horizontal")
            {
                //Flips the image on the X axis
                _imageDisplayed.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }

        /// <summary>
        /// A Method used to change the Contrast, Brightness and Saturation
        /// </summary>
        /// <param name="option">The Option of the Change, Contrast, Brightness or Saturation</param>
        /// <param name="value">The Value of the change (Determaines the strength of the change)</param>
        public void ChangeButton_Click(string option, int pValue)
        {
            //If the Brightness value is changed
            if (option == "brightness")
            {
                //Brightness adjustment code Modified from http://www.authorcode.com/making-image-editing-tool-in-c-brightness-of-an-image/ Accessed 01/04/2022
                //Original code by Hirendra Sisodiya 

                //DECLARES a float called value which is set to pValue * 0.01f
                float value = pValue * 0.01f;
                //Sets an array of colour matrixs
                float[][] colorMatrixElements = {
                new float[] {1,0,0,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,1,0},
                new float[] {value,value,value,0,1}
            };
                //Creates a color Matrix called colorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

                //Creates a ImageAtrributes called imageAttributes
                ImageAttributes imageAttributes = new ImageAttributes();
                //Sets the colorMatrix to colorMatirx
                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                //DECLARES a new Graphics object
                Graphics _g = default(Graphics);
                //Creates a new Bitmap called bm_dest
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(_imageDisplayed.Width), Convert.ToInt32(_imageDisplayed.Height));
                //Sets the graphics to bm_dest
                _g = Graphics.FromImage(bm_dest);
                //Draws the image
                _g.DrawImage(_imageDisplayed, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                //Sets _imageDisplayed to bm_dest
                _imageDisplayed = bm_dest;

            }
            //If the contrast value is changed
            else if (option == "contrast")
            {
                //Contrast adjustment code Modified from https://www.c-sharpcorner.com/uploadfile/75a48f/control-image-contrast-using-asp-net/ Accessed 05/04/2022
                //Original code by Sourabh Somani

                //Sets the contrast value to pValue
                double contrast = pValue;
                //Creates a new temp Bitmap
                Bitmap temp = (Bitmap)_imageDisplayed;
                //Clones temp to bMap
                Bitmap bMap = (Bitmap)temp.Clone();
                //Adds 100 to contrast then devides it by 100
                contrast = (100.0 + contrast) / 100.0;

                //Squares Contrast
                contrast *= contrast;
                //DECLARE a new Colour called col
                Color col;

                //Loops over each pixel in bMap
                for (int i = 0; i < bMap.Width; i++)
                {
                    for (int j = 0; j < bMap.Height; j++)
                    {
                        //Sets col to the colour of the pixel
                        col = bMap.GetPixel(i, j);
                        //Sets the RGB values of the pixels
                        double pRed = col.R;
                        double pGreen = col.G;
                        double pBlue = col.B;
                        //If the value is not 0 this is true
                        if (col.R != 0)
                        {
                            //Devides the value by 255
                            pRed = col.R / 255.0;
                            //Subtracts 0.5
                            pRed -= 0.5;
                            //Times by the contrast
                            pRed *= contrast;
                            //Adds 0.5 to the value
                            pRed += 0.5;
                            //times by 255
                            pRed *= 255;
                            //If the value is less than 0 sets it to 0
                            if (pRed < 0) pRed = 0;
                            //If the value is more than 255 sets it to 255
                            if (pRed > 255) pRed = 255;
                        }
                        //If the value is not 0 this is true
                        if (col.G != 0)
                        {
                            //Devides the value by 255
                            pGreen = col.G / 255.0;
                            //Takes 0.5 away from the value
                            pGreen -= 0.5;
                            //timees the contrast
                            pGreen *= contrast;
                            //Adds 0.5
                            pGreen += 0.5;
                            //Times 255
                            pGreen *= 255;
                            // If the value is less than 0 sets it to 0
                            if (pGreen < 0) pGreen = 0;
                            //If the value is more than 255 sets it to 255
                            if (pGreen > 255) pGreen = 255;
                        }
                        //If the value is not 0 this is true
                        if (col.B != 0)
                        {
                            //Devides the value by 255
                            pBlue = col.B / 255.0;
                            //Subtracts 0.5
                            pBlue -= 0.5;
                            //Times contrast
                            pBlue *= contrast;
                            //Adds 0.5
                            pBlue += 0.5;
                            //Times 255
                            pBlue *= 255;
                            // If the value is less than 0 sets it to 0
                            if (pBlue < 0) pBlue = 0;
                            //If the value is more than 255 sets it to 255
                            if (pBlue > 255) pBlue = 255;
                        }
                        //If the orginal Values are Not 0 this is true
                        if (col.R != 0 && col.B != 0 && col.G != 0)
                        {
                            //Sets the pixel to the colours pRed, pGreen and pBlue
                            bMap.SetPixel(i, j, Color.FromArgb((byte)pRed, (byte)pGreen, (byte)pBlue));
                        }
                    }
                }
                //Sets _imageDisplayed to bMap
                _imageDisplayed = (Bitmap)bMap.Clone();

            }
            //If the saturation value is changed
            else if (option == "saturation")
            {
                //Saturation adjustment code Modified from https://www.codeproject.com/Tips/78995/Image-colour-manipulation-with-ColorMatrix Accessed 01/04/2022
                //Original code by Henry Minute

                //Sets the RGB Weights
                float rWeight = 0.3086f;
                float gWeight = 0.6094f;
                float bWeight = 0.0820f;

                //Sets colour Values for the Colour Matrix
                float a = (1.0f - pValue) * rWeight + pValue;
                float b = (1.0f - pValue) * rWeight;
                float c = (1.0f - pValue) * rWeight;
                float d = (1.0f - pValue) * gWeight;
                float e = (1.0f - pValue) * gWeight + pValue;
                float f = (1.0f - pValue) * gWeight;
                float g = (1.0f - pValue) * bWeight;
                float h = (1.0f - pValue) * bWeight;
                float i = (1.0f - pValue) * bWeight + pValue;

                // ColorMatrix elements
                float[][] ptsArray = {
                                     new float[] {a,  b,  c,  0, 0},
                                     new float[] {d,  e,  f,  0, 0},
                                     new float[] {g,  h,  i,  0, 0},
                                     new float[] {0,  0,  0,  1, 0},
                                     new float[] {0, 0, 0, 0, 1}
                                 };
                //DECLARES a new Graphics object
                Graphics gr = default(Graphics);

                // Create ColorMatrix
                ColorMatrix clrMatrix = new ColorMatrix(ptsArray);
                // Create ImageAttributes
                ImageAttributes imgAttribs = new ImageAttributes();
                // Set color matrix
                imgAttribs.SetColorMatrix(clrMatrix, ColorMatrixFlag.Default, ColorAdjustType.Default);

                //Creates a new Bitmap
                Bitmap curBitmap = new Bitmap(Convert.ToInt32(_imageDisplayed.Width), Convert.ToInt32(_imageDisplayed.Height));

                gr = Graphics.FromImage(curBitmap);
                // Draw Image with image attributes
                gr.DrawImage(_imageDisplayed, new Rectangle(0, 0, curBitmap.Width + 1, curBitmap.Height + 1), 0, 0, curBitmap.Width + 1, curBitmap.Height + 1, GraphicsUnit.Pixel, imgAttribs);

                //Sets _imageDisplay to curBitmap
                _imageDisplayed = curBitmap;

            }
        }

        /// <summary>
        /// A Method that applys filters, Sipea, BlueScale, GreyScale and PhotoNegative
        /// </summary>
        /// <param name="option">The option choosen, Sipea, BlueScale, GreyScale or PhotoNegative</param>
        public void FilterButton_Click(string option)
        {
            //If the Photo negative button is clicked
            if (option == "photo negative")
            {
                ///Photo Negative code Modified from https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-a-negative-image-in-csharp-using-visual-studio Accessed 05/04/2022
                //Original code by Yusuf Shakeel

                //Clones _imageDisplayed to tempImage
                Bitmap tempImage = (Bitmap)((Bitmap)_imageDisplayed).Clone();

                //Loops over each pixel in the Image
                for (int i = 0; i < tempImage.Height; i++)
                {
                    for (int j = 0; j < tempImage.Width; j++)
                    {
                        //DECLARE a color called p , set it to the current pixel
                        Color p = tempImage.GetPixel(i, j);

                        //DECLARE the ARGB values
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.G;

                        //Minus the values from 255
                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;
                        //Set the current pixel to the colours 
                        tempImage.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    //Set _imageDisplayed to tempImage
                    _imageDisplayed = tempImage;
                }
            }
            //If the sepia button is clicked
            else if (option == "sepia")
            {
                ///GreyScale code Modified from https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-sepia-image-in-csharp-using-visual-studio Accessed 05/04/2022
                //Original code by Yusuf Shakeel                
                //Clones _imageDisplayed to tempImage
                Bitmap tempImage = (Bitmap)((Bitmap)_imageDisplayed).Clone();

                //Loops over each pixel in the Image
                for (int i = 0; i < tempImage.Height; i++)
                {
                    for (int j = 0; j < tempImage.Width; j++)
                    {
                        //DECLARE a color called p , set it to the current pixel
                        Color p = tempImage.GetPixel(i, j);

                        //DECLARE the ARGB values
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.G;

                        //DECLARE tR 
                        //times R by 0.393, g by 0.769, b by 0.189
                        int tR = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        //DECLARE tG
                        //times R by 0.349, g by 0.686, b by 0.168
                        int tG = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        //DECLARE tB
                        //times R by 0.272, g by 0.539, b by 0.131
                        int tB = (int)(0.272 * r + 0.539 * g + 0.131 * b);

                        //if tR greater than 255 this is true
                        if (tR > 255)
                        {
                            //R set to 255
                            r = 255;
                        }
                        else
                        {
                            //set r to tR
                            r = tR;
                        }
                        // if tG is greater than 255 this is true
                        if (tG > 255)
                        {
                            //g is Set to 255
                            g = 255;
                        }
                        else
                        {
                            //g is set to tG
                            g = tG;
                        }
                        // if tB is greater than 255
                        if (tB > 255)
                        {
                            //b is 255
                            b = 255;
                        }
                        else
                        {
                            //b is set to tB
                            b = tB;
                        }

                        //Set the current pixel to the colours 
                        tempImage.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    //Set _imageDisplayed to tempImage
                    _imageDisplayed = tempImage;
                }
            }
            //If the greyScale button is clicked
            else if (option == "greyscale")
            {
                ///GreyScale code Modified from https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-a-negative-image-in-csharp-using-visual-studio Accessed 05/04/2022
                //Original code by Yusuf Shakeel

                //Clones _imageDisplayed to tempImage
                Bitmap tempImage = (Bitmap)((Bitmap)_imageDisplayed).Clone();

                //Loops over each pixel in the Image
                for (int i = 0; i < tempImage.Height; i++)
                {
                    for (int j = 0; j < tempImage.Width; j++)
                    {
                        //DECLARE a color called p , set it to the current pixel
                        Color p = tempImage.GetPixel(i, j);

                        //DECLARE the ARGB values
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.G;

                        //Devide values by 5
                        r = r / 5;
                        g = g / 5;
                        b = b / 5;
                        //Set the current pixel to the colours 
                        tempImage.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    //Set _imageDisplayed to tempImage
                    _imageDisplayed = tempImage;
                }
            }
            //If the bluescale button is clicked
            else if (option == "bluescale")
            {
                ///BlueScale code Modified from https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-a-negative-image-in-csharp-using-visual-studio Accessed 05/04/2022
                //Original code by Yusuf Shakeel

                //Clones _imageDisplayed to tempImage
                Bitmap tempImage = (Bitmap)((Bitmap)_imageDisplayed).Clone();

                //Loops over each pixel in the Image
                for (int i = 0; i < tempImage.Height; i++)
                {
                    for (int j = 0; j < tempImage.Width; j++)
                    {
                        //DECLARE a color called p , set it to the current pixel
                        Color p = tempImage.GetPixel(i, j);

                        //DECLARE the ARGB values
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.G;

                        if (b != 0)
                        {
                            //Devides the values by b
                            r = r / b;
                            g = g / b;
                            //Adds b
                            b = b + b;
                            //If b is greater than 255 b is 255
                            if (b > 255) b = 255;
                        }
                        //Set the current pixel to the colours 
                        tempImage.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    //Set _imageDisplayed to tempImage
                    _imageDisplayed = tempImage;
                }
            }
        }

        /// <summary>
        /// A Method used to save the image
        /// </summary>
        public void SaveImageButton_Click()
        {
            //Sets the data to _imageDisplayed
            ((ICommandOneParam<Image>)_saveImage).SetData = _imageDisplayed;
            //Invokes _saveImage
            _commandInvoker.Invoke(_saveImage);
        }
    }
}
