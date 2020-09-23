using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public sealed class MonthlyRecurrence : RecurrencePatternBase
    {
        internal MonthlyRecurrence() : base(FrequencyType.Monthly)
        {
        }
    }
}
