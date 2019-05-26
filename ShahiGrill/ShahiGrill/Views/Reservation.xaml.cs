using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShahiGrill.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservation : ContentPage
    {
        public Reservation()
        {
            InitializeComponent();

            //Navigates from each entry field to the next
            fname.ReturnCommand = new Command(() => lname.Focus());
            lname.ReturnCommand = new Command(() => email.Focus());
            email.ReturnCommand = new Command(() => phone.Focus());
            phone.ReturnCommand = new Command(() => numguests.Focus());

        }

        //Submission button
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success","Reservation has been sent!","OK");
        }
    }
}