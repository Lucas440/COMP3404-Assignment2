using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan & Flynn Osborne
/// 
/// Date 03/04/22
/// </summary>
namespace Server.ServiceLocator
{
    /// <summary>
    /// A Class used to create and store serivces 
    /// </summary>
    public class ServiceLocator : IServiceLocator
    {
        //DECLARE a new IDictionary called _serviceCollection
        IDictionary<Type, IService> _serviceCollection;
        //DECLARE a new IFactory called _serviceFactory
        IFactory _serviceFactory;
        /// <summary>
        /// The Default Constructor for ServiceLocator
        /// </summary>
        public ServiceLocator()
        {
            //INTALISE Class Variables
            //_serviceCollection
            _serviceCollection = new Dictionary<Type, IService>();
            //_serviceFactory
            _serviceFactory = new Factory();
        }
        /// <summary>
        /// A Mehtod that retruns a requested service of type T
        /// </summary>
        /// <typeparam name="T">The Product of the service</typeparam>
        /// <returns>The Service that creates the Product</returns>
        public IService Get<T, C>()
        {
            //If _serviceCollection does not contain a key of type T
            if (!_serviceCollection.ContainsKey(typeof(T)))
            {
                //Adds a new Factory that creates T to _serviceCollection
                _serviceCollection.Add(typeof(T), _serviceFactory.Get<IFactory , Factory>());
            }
            //Returns the Service stored with the key type T
            return _serviceCollection[typeof(T)];
        }
    }
}
