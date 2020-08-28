using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChoreBoard.Utility
{
    public static class EnumHelper
    {
        /// <summary>
        /// Gets all values for the enumeration
        /// </summary>
        /// <typeparam name="T">Enumeration type</typeparam>
        /// <returns>The values for the enumeration</returns>
        public static T[] GetValues<T>() where T : Enum
        {
            return (T[])Enum.GetValues(typeof(T));
        }

        /// <summary>
        /// Gets a collection of the enumeration integer values with their corresponding name
        /// </summary>
        /// <typeparam name="T">Enumeration type</typeparam>
        /// <returns>A collection of the enumeration integer values and their name</returns>
        public static IEnumerable<KeyValuePair<int, string>> GetNameValuePairs<T>() where T : Enum
        {
            var enumValues = GetValues<T>();

            return enumValues.Select(e => new KeyValuePair<int, string>(Convert.ToInt32(e), e.ToString()));
        }
    }
}
