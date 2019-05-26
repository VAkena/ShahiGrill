using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShahiGrill.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShahiGrill.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //Menu item
        private async void TapGestureRecognizerM_TappedAsync(object sender, EventArgs e)
        {
            //Image click count
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            //When image is tapped
            if (tapCount == 1)
            {
                //Navigates to the menu view
                await Navigation.PushAsync(new Menu());
            }
            else
            {
                //Error message if navigation fails
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }
        }

        //Reservations item
        private async void TapGestureRecognizerR_TappedAsync(object sender, EventArgs e)
        {
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            if (tapCount == 1)
            {
                await Navigation.PushAsync(new Reservation());
            }
            else
            {
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }
        }

        //Specials and promotions item
        private async void TapGestureRecognizerS_TappedAsync(object sender, EventArgs e)
        {
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            if (tapCount == 1)
            {
                await Navigation.PushAsync(new Specials());
            }
            else
            {
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }

        }

        //Settings item
        //Navigation not defined
        private async void TapGestureRecognizerSS_TappedAsync(object sender, EventArgs e)
        {
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            if (tapCount == 1)
            {
                await DisplayAlert("Alert", "Feature coming soon!", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }

        }
    }
}