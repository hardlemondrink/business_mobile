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
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        { 
            InitializeComponent();
            Title = "Задачи";
        }
        protected async override void OnAppearing()
        { 
            await DisplayAlert("Внимание!", "Приложение в тестовом режиме", "ОК");
            base.OnAppearing();
        }

    }
}