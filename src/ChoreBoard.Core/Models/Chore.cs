using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public class Chore : Binding.BindingObject, IChore
    {
        private Guid _guid;
        private DateTime _createdDate;
        private IChoreCategory _category;
        private string _name;
        private DateTime _startDate;
        private string _notes;
        private IRecurrencePattern _recurrencePattern;

        public Guid Guid
        {
            get => _guid;
            set => SetProperty(ref _guid, value);
        }

        public DateTime CreatedDate
        {
            get => _createdDate;
            set => SetProperty(ref _createdDate, value);
        }

        public IChoreCategory Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        
        public DateTime StartDate
        {
            get => _startDate;
            set => SetProperty(ref _startDate, value);
        }
        
        public string Notes
        {
            get => _notes;
            set => SetProperty(ref _notes, value);
        }
        public IRecurrencePattern RecurrencePattern
        {
            get => _recurrencePattern;
            set => SetProperty(ref _recurrencePattern, value);
        }
    }
}
