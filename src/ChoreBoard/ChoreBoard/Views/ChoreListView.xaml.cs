using ChoreBoard.Utility.Extensions;
using ChoreBoard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChoreBoard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoreListView : Base.BaseView<ChoreListViewModel>
    {
        public ChoreListView()
        {
            InitializeComponent();
        }

        private async void NewChoreButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewChoreView());
        }
    }
}