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
            Button SwitchColorMode = new Button();
            SwitchColorMode.Clicked += Button_SwitchColorMode;
            SwitchColorMode.Text = "Сменить режим";
            SwitchColorMode.HorizontalOptions = LayoutOptions.Center;
            SwitchColorMode.VerticalOptions = LayoutOptions.End;
        }

        // Не работает еще
        private void Button_SwitchColorMode(object sender, EventArgs e)
        {
            Color color = new Color(00, 00, 00);
            Settings.BackgroundColor = color;
        }
        protected async override void OnAppearing()
        {
            Title = "Задачи";

            var Settings = new TP_Settings
            {
                Title = "Настройки"
            };
            Children.Add(Settings);

            await DisplayAlert("Внимание", "Приложение в тестовом режиме", "ОК");
            base.OnAppearing();
        }

    }
}