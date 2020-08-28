using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public class ChoreCategory : Binding.BindingObject, IChoreCategory
    {
        private Guid _guid;
        private string _name;

        public Guid Guid
        {
            get => _guid;
            set => SetProperty(ref _guid, value);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}
