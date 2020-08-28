using ChoreBoard.Core.Binding;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChoreBoard.ViewModels.Base
{
    public abstract class BaseViewModel : BindingObject
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public abstract Task LoadData();

        protected async Task ExecuteIfNotBusyAsync(Func<Task> func)
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                await func();
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
