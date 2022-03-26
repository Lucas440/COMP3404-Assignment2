using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author Lucas Brennan
/// 
/// Date 25/03/2022
/// </summary>
namespace Server.Exceptions
{
    /// <summary>
    /// A Exception to be thrown when a InvalidFilePath has been given
    /// </summary>
    public class InvalidFilePathException : Exception
    {
        /// <summary>
        /// The Default Constructor
        /// </summary>
        public InvalidFilePathException() : base() { }

        /// <summary>
        /// The Recommended Constructor
        /// </summary>
        /// <param name="message">The message shown to the class that caught the Exception</param>
        public InvalidFilePathException(string message) : base(message){ }

        /// <summary>
        /// A Constructor for when there are other Exceptions Queued
        /// </summary>
        /// <param name="message">The Message shown to the class that caught the Exception</param>
        /// <param name="e">The Exception queued</param>
        public InvalidFilePathException(string message , Exception e) : base(message , e) { }

    }
}
