using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
