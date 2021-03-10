using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Essentials;

using business_mobile.Data;

namespace business_mobile
{
    public partial class App : Application
    {
        static NoteDatabase database;
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
            MainPage = new NavigationPage(new MainPage());
            InitializeComponent();
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
