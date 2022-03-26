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
    /// An exception that is thrown when an InvaildFileType is loaded
    /// </summary>
    public class InvalidFileTypeException : Exception
    {
        /// <summary>
        /// The Default Constructor
        /// </summary>
        public InvalidFileTypeException() : base() { }
        /// <summary>
        /// The Recommended Constructor
        /// </summary>
        /// <param name="message">The message shown to what called the Exception</param>
        public InvalidFileTypeException(string message): base(message){}

        /// <summary>
        /// A constructor for when other exceptions are queued
        /// </summary>
        /// <param name="message">The message shown to what called the Exception</param>
        /// <param name="e">the queued Exception</param>
        public InvalidFileTypeException(string message , Exception e) : base(message , e) { }
    }
}
