using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Utility.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether this string and a specified string object have the same value. The comparison is case insensitive
        /// and uses ordinal sort rules
        /// </summary>
        /// <param name="str">The string for comparison</param>
        /// <param name="compareTo">The value to compare</param>
        /// <returns>True if the two values are equal, ignoring case. Otherwise false</returns>
        public static bool EqualsIgnoreCase(this string str, string compareTo)
        {
            if (str is null)
            {
                return compareTo is null;
            }

            return str.Equals(compareTo, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Returns the default value if the string object is null, empty, or white space
        /// </summary>
        /// <param name="str">The string to check</param>
        /// <param name="defaultValue">The default value</param>
        /// <returns>The default value if the string is null, empty, or white space. Otherwise the string value is returned</returns>
        public static string DefaultTo(this string str, string defaultValue)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return defaultValue;
            }

            return str;
        }
    }
}
