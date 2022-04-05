using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Server.Command;

// AUTHOR: Flynn Osborne & Lucas Brennan
// DATE: 18/03/2022

namespace Server.FormLogic
{
    /// <summary>
    /// A Interface used for the ImageDisplay form
    /// </summary>
    public interface IImageDisplayLogic : IFormLogic
    {

        /// <summary>
        /// A Property used to get the image to be displayed
        /// </summary>
        Image DisplayImage { get; }

        /// <summary>
        /// A Method used to intalise the logic
        /// </summary>
        /// <param name="pImage">The Image that is being displayed</param>
        /// <param name="pSaveCommand">A Command used to save images</param>
        /// <param name="pInvoker">A Command invoker</param>
        void Initialise(Image pImage , ICommand pSaveCommand , ICommandInvoker pInvoker);

        /// <summary>
        /// A Method used to rotatte images
        /// </summary>
        void RotateButton_Click();

        /// <summary>
        /// A Method used to Flip images
        /// </summary>
        /// <param name="option">The option the image is being flipped (Virtical or Horizontal)</param>
        void FlipButton_Click(string option);

        /// <summary>
        /// A Method used to change the Contrast, Brightness and Saturation
        /// </summary>
        /// <param name="option">The Option of the Change, Contrast, Brightness or Saturation</param>
        /// <param name="value">The Value of the change (Determaines the strength of the change)</param>
        void ChangeButton_Click(string option , int value);

        /// <summary>
        /// A Method that applys filters, Sipea, BlueScale, GreyScale and PhotoNegative
        /// </summary>
        /// <param name="option">The option choosen, Sipea, BlueScale, GreyScale or PhotoNegative</param>
        void FilterButton_Click(string option);

        /// <summary>
        /// A Method used to save the image
        /// </summary>
        void SaveImageButton_Click();


    }
}
