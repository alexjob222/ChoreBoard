using ChoreBoard.Data;
using ChoreBoard.Data.DataAccess;
using ChoreBoard.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChoreBoard.ViewModels
{
    public class NewChoreViewModel : Base.BaseViewModel
    {
        private ObservableCollection<ChoreCategory> _choreCategories;
        private bool _isRecurring;

        private IDataService<ChoreCategory> _categoryService;

        public NewChoreViewModel(IDataService<ChoreCategory> categoryService)
        {
            _categoryService = categoryService;

            Title = "New Chore";
            Chore = new Chore() { Name = "Alex's chore" };
            ChoreCategories = new ObservableCollection<ChoreCategory>();

            LoadCategoriesCommand = new Command(async () => await LoadCategoriesAsync());
        }

        public Chore Chore { get; }

        public ObservableCollection<ChoreCategory> ChoreCategories
        {
            get => _choreCategories;
            private set => SetProperty(ref _choreCategories, value);
        }

        public bool IsRecurring
        {
            get => _isRecurring;
            set => SetProperty(ref _isRecurring, value);
        }

        public ICommand LoadCategoriesCommand { get; }

        public override Task LoadData()
        {
            if (ChoreCategories.IsNullOrEmpty())
            {
                return ExecuteIfNotBusyAsync(LoadCategoriesAsync); 
            }

            return Task.CompletedTask;
        }

        private async Task LoadCategoriesAsync()
        {
            var categories = await _categoryService.GetItemsAsync(true);

            ChoreCategories = new ObservableCollection<ChoreCategory>(categories);
        }
    }
}
