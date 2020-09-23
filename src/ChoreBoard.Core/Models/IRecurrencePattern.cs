using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public interface IRecurrencePattern
    {
        FrequencyType FrequencyType { get; }

        int FrequencyInterval { get; set; }

        RolloverType RolloverType { get; set; }

        RolloverFrom RolloverFrom { get; set; }

        int? MaxOccurrences { get; set; }

        DateTime? EndDate { get; set; }
    }
}
