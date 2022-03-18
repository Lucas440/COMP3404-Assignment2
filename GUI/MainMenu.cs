using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Server.FormLogic;
using Server.Command;

// AUTHOR: Flynn Osborne
// DATE: 18/03/2022

namespace GUI
{
    public partial class MainMenu : Form
    {
        //
        private LoadedImages _loadedImagesForm;

        //
        private IMainMenuLogic _logic;

        //
        private ICommandInvoker _invoker;
        private ICommand _command;

        /// <summary>
        /// 
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();

            _logic = new MainMenuLogic();

            _logic.Initalise(_invoker, _command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            _loadedImagesForm = new LoadedImages();

            _loadedImagesForm.Show();
        }
    }
}
