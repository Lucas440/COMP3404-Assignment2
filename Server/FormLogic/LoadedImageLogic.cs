using Server.Exceptions;
using Server.Observer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    public class LoadedImageLogic : ILoadedImageLogic, IButtonClickListener
    {
        //DECLARE a Image called_loadedImages
        private IDictionary<string, Image> _loadedImages;

        public LoadedImageLogic()
        {
            //INITIALISE Class variables
            //_loadedImages
            _loadedImages = new Dictionary<string, Image>();
        }

        /// <summary>
        /// A method that returns an image stored in the dictionary depending on the path
        /// </summary>
        /// <param name="pPath">The path of the image</param>
        /// <returns></returns>
        public Image GetImage(string pPath)
        {
            //returns the image stored
            return _loadedImages[pPath];
        }

        /// <summary>
        /// A Method that loads a new image into the logic
        /// </summary>
        /// <param name="pPath">The Path of the image</param>
        public void LoadNewImage(string pPath)
        {
            try
            {
                //Loads the image from the file path and stores it in the dictionary with the filepath as the key
                _loadedImages.Add(pPath, Bitmap.FromFile(pPath));
            }
            //Catchs an Exception
            catch (Exception)
            {
                //throws a new InvalidFilePathException
                throw new InvalidFilePathException("The File Path Was Invalid!");
            }
        }
        /// <summary>
        /// A Method that loads a new image into the logic From the directory by the users choice
        /// </summary>
        /// <returns>String - Path of the file that was just loaded</returns>
        /// Modified from https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0 Accessed (10/03/2022)
        public string LoadNewImage()
        {
            #region Code from Microsoft
            string path = "";
            //uses the OpenFileDialog class and INITIALISES it
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Sets the InitialDirectory as C
                openFileDialog.InitialDirectory = "c:\\";
                //Only allows for Png Files to be loaded into the program
                //openFileDialog.Filter = "" ;
                //Filters the Index to what is being requested (png)
                openFileDialog.FilterIndex = 2;
                //when called agian the same directory the user left will be loaded
                openFileDialog.RestoreDirectory = true;
                //If the paramiters are ok show the dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Sets the path to the Dialogs filename
                    path = openFileDialog.FileName;
                    try
                    {
                        //Loads the image from the path
                        _loadedImages.Add(path, Bitmap.FromFile(path));
                    }
                    //Catches an Exception
                    catch (Exception)
                    {
                        //throws a new InvalidFileTypeException
                        throw new InvalidFileTypeException("Only Image Files can be Loaded!");
                    }
                }
                #endregion

                return path;
            }
        }
        /// <summary>
        /// A Method used to save Images
        /// </summary>
        /// <param name="pImage">The Image being saved</param>
        public void SaveImage(Image pImage) 
        {
            // Save Image Code Modified from https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.save?view=dotnet-plat-ext-6.0 Accessed (10/03/2022)
            #region Code From MicroSoft
            //uses the OpenFileDialog class and INITIALISES it
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "png files (*.png) | *.png";
                //Sets the InitialDirectory as C
                saveFileDialog.InitialDirectory = "c:\\";
                //If the Dialog result is Ok
                if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    //Saves the File path to path
                    string path = saveFileDialog.FileName;
                    //Saves the image to the path
                    pImage.Save(path);
                }

            }
            #endregion
        }

        // ------------------------------------------- IButtonClickListener implentation ----------------------------------------

        /// <summary>
        /// A Method that responds to a button click event
        /// </summary>
        /// <param name="source">The object that caused the event</param>
        /// <param name="args">the event argument</param>
        public void NewButtonClick(object source, ButtonClickArgs args)
        {
            
        }
        /// <summary>
        /// A Method that responds to a button click event
        /// </summary>
        /// <param name="source">The object that caused the event</param>
        /// <param name="args">the event argument</param>
        /// <returns>An image loaded</returns>
        public Image NewImageGet(object source, ButtonClickArgs args) 
        {
            //DECLARE a new string called path
            string path = "";
            //Trys the followng
            try
            {
                //sets path to what is returned by _loadedImages
                path = LoadNewImage();
                //returns the Image in _loadedImages
                return _loadedImages[path];
            }
            //catches any Exception
            catch (Exception)
            {
                //Throws a new NullFilePathException
                //throw new NullFilePathException("The file path is null!");
            }
            //Returns null
            return null;
        }

    }
}
