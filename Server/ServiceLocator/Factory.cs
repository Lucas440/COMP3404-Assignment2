using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Lucas Brennan
/// DATE: 04/03/22
/// </summary>
namespace Server.ServiceLocator
{
    /// <summary>
    /// A Class used to create new objects of a defined type
    /// </summary>
    public class Factory : IFactory
    {
        /// <summary>
        /// A method that returns a new instance of class type C
        /// </summary>
        /// <typeparam name="T">A type defined when the class is intitalised</typeparam>
        /// <typeparam name="C">A child class of class T</typeparam>
        /// <returns>A new instance of T</returns>
        public T Get<T , C>() where C: T, new() 
        {
            // RETURN a new instance of the class
            return new C();
        }
    }
}
