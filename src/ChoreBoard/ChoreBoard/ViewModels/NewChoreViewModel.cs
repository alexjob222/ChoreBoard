using ChoreBoard.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChoreBoard.ViewModels
{
    public class NewChoreViewModel : Base.BaseViewModel
    {
        public NewChoreViewModel()
        {
            Chore = new Chore() { Name = "Alex's chore" };
            ChoreCategories = new ObservableCollection<ChoreCategory>();
        }

        public Chore Chore { get; set; }

        public ObservableCollection<ChoreCategory> ChoreCategories { get; }
    }
}
