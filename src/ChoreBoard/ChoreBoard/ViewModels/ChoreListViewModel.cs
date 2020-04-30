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
        private IDataService<Chore> _choreService;

        public ChoreListViewModel(IDataService<Chore> choreService)
        {
            _choreService = choreService;

            Chores = new ObservableCollection<Chore>();
            LoadChoresCommand = new Command(async () => await ExecuteLoadChoresCommand());
        }

        public ObservableCollection<Chore> Chores { get; private set; }

        public ICommand LoadChoresCommand { get; }

        private async Task ExecuteLoadChoresCommand()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                Chores.Clear();

                var chores = await _choreService.GetItemsAsync(true);

                foreach (var chore in chores)
                {
                    Chores.Add(chore);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
