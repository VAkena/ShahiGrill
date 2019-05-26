using ShahiGrill.Models;
using ShahiGrill.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShahiGrill
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Password entry becomes the focus after username
            usernameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
        }

        public async void SignIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
            
            //Original signin function
            /*
            Users user = new Users(usernameEntry.Text, passwordEntry.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Success", "Close");
            }
            else
            {
                DisplayAlert("Login", "Failed successfully", "Close");
            }
            */
            
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sign Up", "Feature coming soon!", "OK");
        }
    }
}
