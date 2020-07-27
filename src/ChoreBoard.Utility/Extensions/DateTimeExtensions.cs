using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Utility.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Checks if the passed value is not equal to <see cref="DateTime.MinValue"/>
        /// </summary>
        /// <returns>False if the passed value is equal to <see cref="DateTime.MinValue"/>, otherwise true</returns>
        public static bool HasValue(this DateTime dateTime)
        {
            return dateTime != DateTime.MinValue;
        }

        /// <summary>
        /// Checks if the passed value is not null and has a value that is not equal to <see cref="DateTime.MinValue"/>
        /// </summary>
        /// <returns>False if the passed value is null or is equal to <see cref="DateTime.MinValue"/>, otherwise true</returns>
        public static bool HasValue(this DateTime? dateTime)
        {
            return dateTime.HasValue && dateTime.Value.HasValue();
        }
    }
}
