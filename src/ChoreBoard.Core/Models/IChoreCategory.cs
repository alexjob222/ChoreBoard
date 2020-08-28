using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public interface IChoreCategory
    {
        Guid Guid { get; set; }

        string Name { get; set; }
    }
}
