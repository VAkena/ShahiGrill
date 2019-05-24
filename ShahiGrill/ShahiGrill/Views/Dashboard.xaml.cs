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

        private async void TapGestureRecognizerM_TappedAsync(object sender, EventArgs e)
        {
            int tapCount = 0;
            tapCount++;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if (tapCount == 1)
            {
                await Navigation.PushAsync(new Menu());
            }
            else
            {
                await DisplayAlert("Alert", "Navigation Failed", "OK");
            }
        }

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
    }
}