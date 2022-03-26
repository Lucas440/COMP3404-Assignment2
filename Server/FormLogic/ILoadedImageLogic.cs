using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 18/03/22
/// </summary>
namespace Server.FormLogic
{
    /// <summary>
    /// An interface that represents the logic of the loaded images form
    /// </summary>
    public interface ILoadedImageLogic: IFormLogic
    {
        /// <summary>
        /// A method that returns an image stored in the dictionary depending on the path
        /// </summary>
        /// <param name="pPath">The path of the image</param>
        /// <returns></returns>
        Image GetImage(string pPath);
        /// <summary>
        /// A Method that loads a new image into the logic From the directory by the users choice
        /// </summary>
        /// <returns>String - Path of the file that was just loaded</returns>
        string LoadNewImage();
        /// <summary>
        /// A Method that loads a new image into the logic
        /// </summary>
        /// <param name="pPath">The Path of the image</param>
        void LoadNewImage(string pPath);
    }
}
