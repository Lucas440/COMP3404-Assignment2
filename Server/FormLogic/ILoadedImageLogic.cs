using System;
using System.Collections.Generic;
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
    public interface ILoadedImageLogic
    {
        /// <summary>
        /// A Method that loads a new image into the logic From the directory by the users choice
        /// </summary>
        void LoadNewImage();
        /// <summary>
        /// A Method that loads a new image into the logic
        /// </summary>
        /// <param name="pPath">The Path of the image</param>
        void LoadNewImage(string pPath);
    }
}
