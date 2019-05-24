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

        //Menu
        private async void TapGestureRecognizerM_TappedAsync(object sender, EventArgs e)
        {
            //Counts the amount of times the image is clicked
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if (tapCount == 1)
            {
                //Handles navigation to the specified page
                await Navigation.PushAsync(new Menu());
            }
            else
            {
                //Displays error message if navigation task fails
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }
        }

        //Reservations
        private async void TapGestureRecognizerR_TappedAsync(object sender, EventArgs e)
        {
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if (tapCount == 1)
            {
                await Navigation.PushAsync(new Reservation());
            }
            else
            {
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }
        }

        //Specials and promotions
        private async void TapGestureRecognizerS_TappedAsync(object sender, EventArgs e)
        {
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if (tapCount == 1)
            {
                await Navigation.PushAsync(new Specials());
            }
            else
            {
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }

        }

        private async void TapGestureRecognizerSS_TappedAsync(object sender, EventArgs e)
        {
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
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