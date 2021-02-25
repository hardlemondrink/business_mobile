using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace business_mobile
{
    public partial class App : Application
    {
        authorization auth = new authorization();
        user user = new user();
        Color blackColor = new Color(00, 00, 00);
        public App()
        {
            InitializeComponent();
            
            user.userid = ""; // Номер телефона из БД телефона надо как-то сохранять и подтягивать
            user.deviceid = ""; // Установка id устройства также нужно как-то сохранять и подгружать

            bool isAuth = auth.IsAuth(user.userid);
            if (isAuth) {
                HomePage homePage = new HomePage
                {
                    Title = "Задачи"
                };
                homePage.Children.Add(new TP_Settings
                {  
                    Title = "Настройки"
                });
                MainPage = new NavigationPage(homePage);
            } else
            {
                MainPage = new NavigationPage(new MainPage());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
