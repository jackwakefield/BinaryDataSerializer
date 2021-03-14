using System;

namespace BinaryDataSerialization
{
    /// <summary>
    ///     Represents an binding exception.
    /// </summary>
    public class BindingException : Exception
    {
        internal BindingException(string message) : base(message)
        {
        }
    }
}
