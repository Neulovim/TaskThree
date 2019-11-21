using System;
using System.Windows.Input;
using TaskThree;
using Xamarin.Forms;

namespace VideoPlayerDemos
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        async void OnNextPageOneButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayWebVideoPage { Title = "Page 1" });
        }

        async void OnNextPageTwoButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTwo { Title = "Page 2" });
        }

        async void OnNextPageThreeButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageThree { Title = "Page 3" });
        }
    }
}