using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Utility
{
    public static class Ensure
    {
        /// <summary>
        /// Checks the argument and throws an exception if it is null
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Thrown when argument is null</exception>
        public static void ArgumentNotNull(object argument, string argumentName)
        {
            if (argument is null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Checks the condition and throws an exception if it false
        /// </summary>
        /// <exception cref="System.ArgumentException">Thrown when condition is false</exception>
        public static void ArgumentCondition(bool condition, string argumentName, string message)
        {
            if (!condition)
            {
                throw new ArgumentException(message, argumentName);
            }
        }

        /// <summary>
        /// Checks the value and throws an exception if it is null
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown when value is null</exception>
        public static void IsNotNull(object value, string message)
        {
            if (value is null)
            {
                throw new InvalidOperationException(message);
            }
        }

        /// <summary>
        /// Checks the condition and throws an exception if it is true
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown when condition is true</exception>
        public static void IsFalse(bool condition, string message)
        {
            if (condition)
            {
                throw new InvalidOperationException(message);
            }
        }

        /// <summary>
        /// Checks the condition and throws an exception if it is false
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown when condition is false</exception>
        public static void IsTrue(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}
