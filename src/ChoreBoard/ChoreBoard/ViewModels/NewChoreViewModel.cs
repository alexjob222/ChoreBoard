using ChoreBoard.Core.Models;
using ChoreBoard.Data.DataAccess;
using ChoreBoard.Utility;
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
        private ObservableCollection<IChoreCategory> _choreCategories;
        private bool _isRecurring;

        private readonly IDataService<IChoreCategory> _categoryService;

        public NewChoreViewModel(IDataService<IChoreCategory> categoryService)
        {
            _categoryService = categoryService;

            Title = "New Chore";
            Chore = new Chore() { Name = "Alex's chore" };

            ChoreCategories = new ObservableCollection<IChoreCategory>();
            RolloverTypes = EnumHelper.GetValues<RolloverType>();
            RolloverFromOptions = EnumHelper.GetValues<RolloverFrom>();

            LoadCategoriesCommand = new Command(async () => await LoadCategoriesAsync());
        }

        public IChore Chore { get; }

        public ICommand LoadCategoriesCommand { get; }

        public IEnumerable<RolloverType> RolloverTypes { get; }

        public IEnumerable<RolloverFrom> RolloverFromOptions { get; }

        public ObservableCollection<IChoreCategory> ChoreCategories
        {
            get => _choreCategories;
            private set => SetProperty(ref _choreCategories, value);
        }

        public bool IsRecurring
        {
            get => _isRecurring;
            set => SetProperty(ref _isRecurring, value);
        }

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

            ChoreCategories = new ObservableCollection<IChoreCategory>(categories);
        }
    }
}
