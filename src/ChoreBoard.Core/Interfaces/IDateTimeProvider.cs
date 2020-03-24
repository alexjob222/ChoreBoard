using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Interfaces
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }

        DateTime UtcNow { get; }
    }
}
