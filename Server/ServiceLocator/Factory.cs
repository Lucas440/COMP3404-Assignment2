using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan
/// 
/// Date: 04/03/22
/// </summary>
namespace Server.ServiceLocator
{
    /// <summary>
    /// A Class used to create new objects of a defined type
    /// </summary>
    /// <typeparam name="T">A Type defined when the class is intitalised</typeparam>
    public class Factory<T> : IFactory<T>
    {
        /// <summary>
        /// A Class that returns a new instence of class type C
        /// </summary>
        /// <typeparam name="C">A child class of class T</typeparam>
        /// <returns>A new intence of T</returns>
        public T Get<C>() where C: T, new() 
        {
            //Retuns a new Class C
            return new C();
        }
    }
}
