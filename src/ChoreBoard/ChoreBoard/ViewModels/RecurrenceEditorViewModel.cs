using ChoreBoard.Data;
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
            Recurrence = new RecurrencePattern();
        }

        public RecurrencePattern Recurrence { get; }

        public override Task LoadData()
        {
            return Task.CompletedTask;
        }
    }
}
