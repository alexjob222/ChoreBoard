using ChoreBoard.Core;
using ChoreBoard.Setup;
using ChoreBoard.Utility;
using ChoreBoard.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChoreBoard
{
    public partial class App : Application
    {
        public App(AppSetup appSetup)
        {
            Ensure.ArgumentNotNull(appSetup, nameof(appSetup));

            InitializeComponent();

            Dependencies.Container = appSetup.CreateContainer();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
