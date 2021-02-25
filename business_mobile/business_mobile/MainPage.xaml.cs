using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace business_mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Registration(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registration_Step());
        }
        private async void Button_Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
        private async void Button_FreeLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
