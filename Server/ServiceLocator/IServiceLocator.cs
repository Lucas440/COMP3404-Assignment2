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
    /// An interface that represents a ServiceLocator
    /// Used to Get IServices
    /// </summary>
    public interface IServiceLocator
    {
        /// <summary>
        /// A method that returns an IService
        /// </summary>
        /// <typeparam name="T">The Product of the Serive</typeparam>
        /// /// <typeparam name="C">The child of The Product of the Serive</typeparam>
        /// <returns>The Creator of the Product</returns>
        IService Get<T , C>();
    }
}
