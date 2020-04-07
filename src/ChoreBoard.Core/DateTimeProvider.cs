using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core
{
    public class DateTimeProvider : Interfaces.IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;

        public DateTime UtcNow => DateTime.UtcNow;

        public DateTime Today => DateTime.Today;
    }
}
