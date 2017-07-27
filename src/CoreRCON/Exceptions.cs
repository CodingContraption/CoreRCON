using System;

namespace CoreRCON
{
	/// <summary>
	/// Basically just another Exception.
	/// </summary>
	public class AuthenticationException : Exception
	{
        public AuthenticationException() { }
        public AuthenticationException(string message) : base(message) { }
        public AuthenticationException(string message, Exception innerException) : base(message, innerException) { }
    }

    /// <summary>
    /// Exception thrown when a receive connection can't be established.
    /// </summary>
    public class UnreachableHostException : Exception
    {
        public UnreachableHostException() { }
        public UnreachableHostException(string message) : base(message) { }
        public UnreachableHostException(string message, Exception innerException) : base(message, innerException) { }
    }
}