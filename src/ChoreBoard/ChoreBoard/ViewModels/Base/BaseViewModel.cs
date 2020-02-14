using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.ViewModels.Base
{
    abstract class BaseViewModel : BindingObject
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }

    abstract class BaseViewModel<TModel> : BaseViewModel
    {
        private TModel _model;

        public TModel Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }
    }
}
