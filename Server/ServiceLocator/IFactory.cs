using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ServiceLocator
{
    /// <summary>
    /// An interface used to Represent a Factory used to create Items of Type T
    /// Defined by the user
    /// </summary>
    public interface IFactory : IService
    {
        /// <summary>
        /// A Method that returns a new Intance of a defined class
        /// </summary>
        /// <typeparam name="T">A type defined by the user</typeparam>
        /// <typeparam name="C">A Child class of T</typeparam>
        /// <returns>A new intance of class T</returns>
        T Get<T , C>() where C : T, new();
    }
}
