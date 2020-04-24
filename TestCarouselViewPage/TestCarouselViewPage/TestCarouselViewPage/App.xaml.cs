using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestCarouselViewPage.Services;
using TestCarouselViewPage.Views;

namespace TestCarouselViewPage
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
