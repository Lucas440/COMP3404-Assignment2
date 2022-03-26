using Server.Command;
using Server.ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3404
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DECLARES and INTALISES a new serviceLocator
            IServiceLocator serviceLocator = new ServiceLocator();
            //DECLARES and INTALISES a new commandInvoker using the service Locator
            ICommandInvoker commandInvoker = (serviceLocator.Get<ICommandInvoker, CommandInvoker>() as IFactory).Get<ICommandInvoker , CommandInvoker>();

            //DECLARES and Initalises Controler using serviceLocator
            IController controller = (serviceLocator.Get<IController , Controller>() as IFactory).Get<IController ,Controller>();
            //Initalises controller
            controller.Initalise(serviceLocator , commandInvoker);
        }
    }
}
