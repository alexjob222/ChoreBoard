using ChoreBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Factory
{
    public static class RecurrencePatternFactory
    {
        public static IRecurrencePattern Build(FrequencyType frequencyType)
        {
            switch (frequencyType)
            {
                case FrequencyType.Daily:
                    return new DailyRecurrence();
                case FrequencyType.Weekly:
                    return new WeeklyRecurrence();
                case FrequencyType.Monthly:
                    return new MonthlyRecurrence();
                default:
                    throw new ArgumentException("Frequency type not recognized", nameof(frequencyType));
            }
        }
    }
}
