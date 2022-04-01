using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

// AUTHOR: Flynn Osborne & Lucas Brennan
// DATE: 18/03/2022

namespace Server.FormLogic
{
    public interface IImageDisplayLogic : IFormLogic
    {

        /// <summary>
        /// A Property used to get the image to be displayed
        /// </summary>
        Image DisplayImage { get; }

        /// <summary>
        /// 
        /// </summary>
        void Initialise(Image pImage);

        /// <summary>
        /// 
        /// </summary>
        Image RotateButton_Click();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="option"></param>
        Image FlipButton_Click(string option);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        void ChangeButton_Click(string option , int value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        void FilterButton_Click(string option);

        /// <summary>
        /// 
        /// </summary>
        void SaveImageButton_Click();


    }
}
