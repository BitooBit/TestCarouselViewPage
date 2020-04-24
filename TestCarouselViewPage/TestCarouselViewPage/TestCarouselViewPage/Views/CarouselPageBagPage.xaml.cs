using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TestCarouselViewPage.Views
{

    public partial class CarouselPageBagPage : CarouselPage
    {

        public CarouselPageBagPage(bool val)
        {
            NavigationPage.SetHasNavigationBar(this, val);
            InitializeComponent();
            ItemsSource = new List<Item>
            {
                new Item (Color.Red),
                new Item (Color.Green),
                new Item (Color.Olive)
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}