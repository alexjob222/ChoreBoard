using System;
using System.Collections.Generic;
using System.Linq;

namespace ChoreBoard.Utility.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Checks if the passed enumerable is null or empty
        /// </summary>
        /// <returns>True if the enumerable is null or does not contain any elements, otherwise false</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable is null || !enumerable.Any();
        }
    }
}