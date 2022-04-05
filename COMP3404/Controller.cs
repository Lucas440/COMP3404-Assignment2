using Server.Command;
using Server.FormLogic;
using Server.ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Command;
using GUI;
using Server.Observer;
using System.Drawing;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date: 04/03/22
/// </summary>
namespace COMP3404
{
    /// <summary>
    /// A class that controls high levels inside the program
    /// </summary>
    public class Controller : IController
    {
        //DECLARE a IServiceLocator called _serviceLocator
        public IServiceLocator _serviceLocator;

        //DECLARE a ICommandInvoker called _commandInvoker
        public ICommandInvoker _commandInvoker;

        IDictionary<IFormLogic, Form> _formDictionary;

        ICommand _saveImageCommand;

        public ICommandInvoker Invoker
        {
            get { return _commandInvoker; }
        }

        public IServiceLocator Locator
        {
            get { return _serviceLocator; }
        }

        /// <summary>
        /// The Default Constructor for Controller
        /// </summary>
        public Controller() 
        {
        }

        /// <summary>
        /// A Method used to intialise Controller
        /// </summary>
        /// <param name="pLocator">A Service Locator</param>
        /// <param name="pInvoker">A Command Invoker</param>
        public void Initalise(IServiceLocator pLocator, ICommandInvoker pInvoker) 
        {
            //INTIALISE Class variables
            //_serviceLocator
            _serviceLocator = pLocator;
            //_commandInvoker
            _commandInvoker = pInvoker;

            _formDictionary = new Dictionary<IFormLogic, Form>();

            //DECLARE and INTIALSE a Form called _mainMenuForm using _serviceLocator
            Form _mainMenuForm = (_serviceLocator.Get<Form , GUI.MainMenu>() as IFactory).Get<Form , GUI.MainMenu>();

            //DECLARE and INTIALSE a ICommand called _addDisplayCommand using _serviceLocator
            ICommand _addDisplayCommand = (_serviceLocator.Get<ICommand, CommandZeroParam>() as IFactory).Get<ICommand, CommandZeroParam>();

            //Set the action to AddDisplay
            ((ICommandZeroParam)_addDisplayCommand).SetAction = AddLoadedImageForm;
            //CREATES a new IMainMenuLogic called menuLogic
            IMainMenuLogic menuLogic = (_serviceLocator.Get<IMainMenuLogic, MainMenuLogic>() as IFactory).Get<IMainMenuLogic, MainMenuLogic>();
            
            // Intialises menuLogic
            menuLogic.Initalise(_commandInvoker , _addDisplayCommand);

            //Subscribes menuLogic to _mainMenuForm
            ((IButtonClickPublisher)_mainMenuForm).Subscribe((IButtonClickListener)menuLogic);

            //Adds menuLogic as a key and _mainMenuForm
            _formDictionary.Add(menuLogic , _mainMenuForm);

            //Runs _mainMenuForm
            Application.Run(_mainMenuForm);
        }
        /// <summary>
        /// a Method for adding new LoadedImage forms
        /// </summary>
        public void AddLoadedImageForm()
        {
            //Creates a new LoadedImages form using the serviceLoactor
            Form tempForm = (_serviceLocator.Get<Form, LoadedImages>() as IFactory).Get<Form, LoadedImages>();
            //Creates a new LoadedImagesLogic using the serviceLocator
            IFormLogic tempLogic = (_serviceLocator.Get<IFormLogic , ILoadedImageLogic>() as IFactory).Get<IFormLogic , LoadedImageLogic>();

            //Creates a New Command called addImageDisplay using _serviceLocator
            ICommand addImageDisplay = (_serviceLocator.Get<ICommand , ICommandOneParam<Image>>() as IFactory).Get<ICommandOneParam<Image> , CommandOneParam<Image>>();
            //INTIALISES _saveImageCommand using _serviceLocator
            _saveImageCommand = (_serviceLocator.Get<ICommand, ICommandOneParam<Image>>() as IFactory).Get<ICommandOneParam<Image>, CommandOneParam<Image>>();
            //Sets the action to tempLogic save image
            ((ICommandOneParam<Image>)_saveImageCommand).SetAction = ((ILoadedImageLogic)tempLogic).SaveImage;
            //Sets the Action to AddImageDisplayForm
            ((ICommandOneParam<Image>)addImageDisplay).SetAction = AddImageDisplayForm;
            //Intialises the form passing _commandInvoker and addImageDisplay
            ((LoadedImages)tempForm).Initialise(_commandInvoker , addImageDisplay);

            //Subscribes tempLogic to the Publisher
            ((IButtonClickPublisher)tempForm).Subscribe((IButtonClickListener)tempLogic);

            //Adds the form and the logic to the dictionary
            _formDictionary.Add(tempLogic , tempForm);
            //Shows the form
            tempForm.Show();
        }
        /// <summary>
        /// A Methood used to Add a ImageDisplay Form
        /// </summary>
        /// <param name="pDisplayImage">The Image the form will be displaying</param>
        public void AddImageDisplayForm(Image pDisplayImage) 
        {
            //Creates a new LoadedImages form using the serviceLoactor
            Form tempForm = (_serviceLocator.Get<Form, ImageDisplay>() as IFactory).Get<Form, ImageDisplay>();
            //Creates a new ImageDisplayLogic using the serviceLocator
            IFormLogic tempLogic = (_serviceLocator.Get<IFormLogic, IImageDisplayLogic>() as IFactory).Get<IFormLogic, ImageDisplayLogic>();
            
            //Intialises tempForm passing pDisplayImage
            ((ImageDisplay)tempForm).Intialise(pDisplayImage , _saveImageCommand , Invoker);

            //Adds the form and the logic to the dictionary
            _formDictionary.Add(tempLogic, tempForm);
            //Shows the form
            tempForm.Show();
        }
    }
}
