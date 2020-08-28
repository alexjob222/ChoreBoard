using ChoreBoard.Core.Models;
using ChoreBoard.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChoreBoard.ViewModels
{
    public class RecurrenceEditorViewModel : Base.BaseViewModel
    {
        public RecurrenceEditorViewModel()
        {
            FrequencyTypes = EnumHelper.GetValues<FrequencyType>();
        }

        public IRecurrencePattern Recurrence { get; }

        public IEnumerable<FrequencyType> FrequencyTypes { get; }

        public override Task LoadData()
        {
            return Task.CompletedTask;
        }
    }
}
