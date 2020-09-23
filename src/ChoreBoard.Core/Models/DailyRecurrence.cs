using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public sealed class DailyRecurrence : RecurrencePatternBase
    {
        internal DailyRecurrence() : base(FrequencyType.Daily)
        {
        }
    }
}
