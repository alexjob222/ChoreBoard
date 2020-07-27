using ChoreBoard.Data;
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
        private ObservableCollection<Chore> _chores;

        private IDataService<Chore> _choreService;

        public ChoreListViewModel(IDataService<Chore> choreService)
        {
            _choreService = choreService;

            Title = "ChoreBoard";

            Chores = new ObservableCollection<Chore>();
            LoadChoresCommand = new Command(async () => await LoadChoresAsync());
        }

        public ObservableCollection<Chore> Chores
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

            Chores = new ObservableCollection<Chore>(chores);
        }
    }
}
