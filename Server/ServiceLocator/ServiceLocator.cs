using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Lucas Brennan & Flynn Osborne
/// DATE: 03/04/22
/// </summary>
namespace Server.ServiceLocator
{
    /// <summary>
    /// A class used to create and store services 
    /// </summary>
    public class ServiceLocator : IServiceLocator
    {
        // DECLARE a new IDictionary called _serviceCollection
        IDictionary<Type, IService> _serviceCollection;

        // DECLARE a new IFactory called _serviceFactory
        IFactory _serviceFactory;

        /// <summary>
        /// The Default Constructor for ServiceLocator
        /// </summary>
        public ServiceLocator()
        {
            // INITIALISE Class Variables
            //_serviceCollection
            _serviceCollection = new Dictionary<Type, IService>();
            //_serviceFactory
            _serviceFactory = new Factory();
        }
        /// <summary>
        /// A method that returns a requested service of type T
        /// </summary>
        /// <typeparam name="T">The product of the service</typeparam>
        /// <returns>The service that creates the product</returns>
        public IService Get<T, C>()
        {
            // IF _serviceCollection does not contain a key of type T
            if (!_serviceCollection.ContainsKey(typeof(T)))
            {
                // ADD a new Factory that creates T to _serviceCollection
                _serviceCollection.Add(typeof(T), _serviceFactory.Get<IFactory , Factory>());
            }

            // RETURN the service stored with the key type T
            return _serviceCollection[typeof(T)];
        }
    }
}
