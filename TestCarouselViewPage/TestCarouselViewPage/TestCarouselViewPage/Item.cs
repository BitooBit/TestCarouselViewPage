using System;
using System.ComponentModel;
using Xamarin.Forms;


namespace TestCarouselViewPage.Views
{
    public class Item : INotifyPropertyChanged
    {
        public Item()
        {
        }

        public Item(Color color, string url)
        {
            Color = color;
            Url = new Uri(url);
            Image = new UriImageSource()
            {
                CachingEnabled = false,
                Uri = Url
            };
        }


        public Item(Color color)
        {
            Color = color;

        }

        public Color Color { get; set; }
        public Uri Url { get; set; }
        public ImageSource Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}