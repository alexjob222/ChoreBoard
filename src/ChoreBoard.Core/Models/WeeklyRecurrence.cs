using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public sealed class WeeklyRecurrence : RecurrencePatternBase
    {
        internal WeeklyRecurrence() : base(FrequencyType.Weekly)
        {
        }
    }
}
