using ChoreBoard.Core.Models;
using ChoreBoard.Data.DataAccess;
using ChoreBoard.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChoreBoard.ViewModels
{
    public class ChoreListViewModel : Base.BaseViewModel
    {
        private ObservableCollection<IChore> _chores;

        private IDataService<IChore> _choreService;

        public ChoreListViewModel(IDataService<IChore> choreService)
        {
            _choreService = choreService;

            Title = "ChoreBoard";

            Chores = new ObservableCollection<IChore>();
            LoadChoresCommand = new Command(async () => await LoadChoresAsync());
        }

        public ObservableCollection<IChore> Chores
        { 
            get => _chores;
            private set => SetProperty(ref _chores, value);
        }

        public ICommand LoadChoresCommand { get; }

        public override Task LoadData()
        {
            if (Chores.IsNullOrEmpty())
            {
                return ExecuteIfNotBusyAsync(LoadChoresAsync);
            }

            return Task.CompletedTask;
        }

        private async Task LoadChoresAsync()
        {
            var chores = await _choreService.GetItemsAsync(true);

            Chores = new ObservableCollection<IChore>(chores);
        }
    }
}
