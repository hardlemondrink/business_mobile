using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using business_mobile.TasksView;

namespace business_mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TP_Home1 : ContentPage
    {
        public TP_Home1()
        {
            InitializeComponent();
        }
        public string[] tasks { get; set; }

        private void taskList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null)
            {
                selected.Text = e.Item.ToString();
                ((ListView)sender).SelectedItem = null;
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            taskList.ItemsSource = await App.Database.GetNotesAsync("Test");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTask());
        }
    }
}