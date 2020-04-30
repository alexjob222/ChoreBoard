using ChoreBoard.Setup;
using ChoreBoard.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ChoreBoard.Views.Base
{
    public abstract class BaseView<TViewModel> : ContentPage where TViewModel : BaseViewModel
    {
        public TViewModel ViewModel { get; }

        public BaseView()
        {
            ViewModel = Dependencies.Resolve<TViewModel>();

            BindingContext = ViewModel;
        }
    }
}
