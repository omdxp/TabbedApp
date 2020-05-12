using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoTeSecondPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new TabbedPage1()));
        }

        private async void ShowAlert(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Title", "Message", "Accept", "Cancel");
        }

        private async void ShowActionSheet(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Title", "Cancel", "Destruction",
                "param 1",
                "param 2",
                "param 3");
        }
    }
}
