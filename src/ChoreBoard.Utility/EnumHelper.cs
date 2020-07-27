using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChoreBoard.Utility
{
    public static class EnumHelper
    {
        public static T GetEnumValues<T>()
        {
            var values = Enum.GetValues(typeof(T)).Cast<T>()
        }
    }
}
