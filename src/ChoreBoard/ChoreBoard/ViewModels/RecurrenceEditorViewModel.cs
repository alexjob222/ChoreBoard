using ChoreBoard.Core.Models;
using ChoreBoard.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreBoard.ViewModels
{
    public class RecurrenceEditorViewModel : Base.BaseViewModel
    {
        public RecurrenceEditorViewModel()
        {
            FrequencyTypes = EnumHelper.GetValues<FrequencyType>();
            DaysOfWeek = EnumHelper.GetValues<DayOfWeek>()
                                   .Select(e => e.ToString())
                                   .ToList();
            SelectedDays = new ObservableCollection<string>();
        }

        public IRecurrencePattern Recurrence { get; }

        public IEnumerable<FrequencyType> FrequencyTypes { get; }

        public FrequencyType SelectedFrequency { get; set; }

        public IEnumerable<string> DaysOfWeek { get; }

        public ObservableCollection<string> SelectedDays { get; set; }

        public override Task LoadData()
        {
            return Task.CompletedTask;
        }
    }
}
