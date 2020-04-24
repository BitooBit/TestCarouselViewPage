using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TestCarouselViewPage.Views
{

    public partial class CarouselViewBagPage : ContentPage, INotifyPropertyChanged
    {

        public CarouselViewBagPage(bool val)
        {
            NavigationPage.SetHasNavigationBar(this, val);
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Item> ItemsSource { get; private set; } = new List<Item>
            {
                new Item (Color.Red),
                new Item (Color.Green),
                new Item (Color.Olive)
            };

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
