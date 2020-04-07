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
    public partial class ChoreListView : ContentPage
    {
        private ChoreListViewModel viewModel;
        private bool isActionBtnOpen = false;

        private const int AnimationLength = 175;

        public ChoreListView()
        {
            InitializeComponent();

            var chores = Enumerable.Range(1, 15)
                        .Select(i => new Data.Chore
                        {
                            Name = $"Chore {i}",
                            Description = $"This is the description for chore {i}",
                            Notes = $"If I had notes, this is where they would go. That's why I added the field to the model"
                        });

            viewModel = new ChoreListViewModel(chores);

            BindingContext = viewModel;
        }

        private async void btnAction_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (isActionBtnOpen)
            {
                //Don't await this call. I want the next animation to begin while this is ongoing
                btn.RotateTo(0);

                await btnTest.TranslateTo(0, 0);
                btnTest.IsVisible = false;
            }
            else
            {
                //Don't await this call. I want the next animation to begin while this is ongoing
                btn.RotateTo(135);

                btnTest.IsVisible = true;
                await btnTest.TranslateTo(0, -100);
            }

            isActionBtnOpen = !isActionBtnOpen;
        }
    }
}