using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Flynn Osborne
/// DATE: 01/04/2022
/// </summary>

namespace Server.Exceptions
{
    /// <summary>
    /// An exception that is thrown when the file path returned is null
    /// </summary>
    public class NullFilePathException : Exception
    {
        /// <summary>
        /// The default constructor
        /// </summary>
        public NullFilePathException() : base() { }

        /// <summary>
        /// The recommended constructor
        /// </summary>
        /// <param name="message">The message shown to whatever caused the exception</param>
        public NullFilePathException(string message) : base(message) { }

        /// <summary>
        /// A constructor for when other exceptions are queued
        /// </summary>
        /// <param name="message">The message shown to whatever caused the exception</param>
        /// <param name="e">The queued exception</param>
        public NullFilePathException(string message, Exception e) : base(message, e) { }
    }
}
