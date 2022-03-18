using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// AUTHOR: Flynn Osborne & Lucas Brennan
// DATE: 18/03/2022

namespace Server.FormLogic
{
    public interface IImageDisplayLogic
    {
        /// <summary>
        /// 
        /// </summary>
        void Initialise();

        /// <summary>
        /// 
        /// </summary>
        void RotateButton_Click();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        void FlipButton_Click(string option);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        void ChangeButton_Click(string option);

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
