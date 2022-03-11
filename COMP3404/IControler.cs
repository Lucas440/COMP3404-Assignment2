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
    /// An interface used to control high level classes
    /// </summary>
    public interface IControler
    {
        /// <summary>
        /// A Method used to intialise Controller
        /// </summary>
        /// <param name="pLocator">A Service Locator</param>
        /// <param name="pInvoker">A Command Invoker</param>
        void Initalise(IServiceLocator pLocator, ICommandInvoker pInvoker);
        
        /// <summary>
        /// A method used to add new displays to the screen
        /// </summary>
        void AddDisplay();
    }
}
