using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 04/03/22
/// </summary>
namespace Server.FormLogic
{
    /// <summary>
    /// A class that represents the logic of the loaded images form
    /// </summary>
    public class LoadedImageLogic : ILoadedImageLogic
    {
        //DECLARE a Image called_loadedImages
        private Image _loadedImage;
        //DECLARE a Property called LoadedImage which returns _loadedImage
        public Image LoadedImage { get => _loadedImage; }

        /// <summary>
        /// A Method that loads a new image into the logic
        /// </summary>
        /// <param name="pPath">The Path of the image</param>
        public void LoadNewImage(string pPath) 
        {
            //Loads the image from the file path
            _loadedImage = Bitmap.FromFile(pPath);
        }
        /// <summary>
        /// A Method that loads a new image into the logic From the directory by the users choice
        /// </summary>
        /// Modified from https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0 Accessed (10/03/2022)
        public void LoadNewImage() 
        {
            //uses the OpenFileDialog class and INITALISES it
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                //Sets the InitialDirectory as C
                openFileDialog.InitialDirectory = "c:\\";
                //Only allows for Png Files to be loaded into the program
                openFileDialog.Filter = "png files (*.png) | *.png" ;
                //Filters the Index to what is being requested (png)
                openFileDialog.FilterIndex = 2;
                //when called agian the same directory the user left will be loaded
                openFileDialog.RestoreDirectory = true;
                //If the paramiters are ok show the dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    //Sets the path to the Dialogs filename
                    string path = openFileDialog.FileName;
                    //Loads the image from the path
                    _loadedImage = Bitmap.FromFile(path);
                }
            }
        }
    }
}
