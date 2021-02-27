using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using business_mobile.Data;
using System.IO;

namespace business_mobile
{
    public partial class App : Application
    {
        static NoteDatabase database;
        public static User user;
        public static void SetUserParams()
        {
            user.userid = "Test";
        }
        public static NoteDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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
