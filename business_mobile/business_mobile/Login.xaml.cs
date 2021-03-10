using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace business_mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        public string UserID { get; private set; }

        private void SetUserID(string id)
        {
            UserID = id;
            Preferences.Set("userid", UserID);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SetUserID(EntryPhone.Text);
            
        }
    }
}