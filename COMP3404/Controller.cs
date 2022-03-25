using Server.Command;
using Server.ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public void AddDisplay() 
        {
            
        }
    }
}
