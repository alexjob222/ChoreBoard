using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Data
{
    public enum ActionType
    {
        Completed = 1,
        Skipped = 2,
        AutoRollover = 3,
    }

    public enum FrequencyType
    {
        Daily = 1,
        Weekly = 2,
        Monthly = 3,
    }

    public enum RolloverType
    {
        Automatic = 1,
        OnCompletion = 2,
    }

    public enum RolloverFrom
    {
        DueDate = 1,
        CompletionDate = 2,
    }
}
