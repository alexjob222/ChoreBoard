using ChoreBoard.Data;
using ChoreBoard.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ChoreBoard.ViewModels
{
    public class ChoreListViewModel : Base.BaseViewModel
    {
        public ChoreListViewModel() : this(null) 
        { }

        public ChoreListViewModel(IEnumerable<Chore> chores)
        {
            Chores = new ObservableCollection<Chore>(chores.EmptyIfNull());
        }

        public ObservableCollection<Chore> Chores { get; }
    }
}
