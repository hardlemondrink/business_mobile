using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace business_mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration_Step : ContentPage
    {
        public Registration_Step()
        {
            InitializeComponent();
            Title = "Регистрация";
        }
    }
}