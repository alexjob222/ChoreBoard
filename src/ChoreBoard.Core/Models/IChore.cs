using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public interface IChore
    {
        Guid Guid { get; set; }

        DateTime CreatedDate { get; set; }

        IChoreCategory Category { get; set; }

        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Notes { get; set; }

        IRecurrencePattern RecurrencePattern { get; set; }
    }
}
