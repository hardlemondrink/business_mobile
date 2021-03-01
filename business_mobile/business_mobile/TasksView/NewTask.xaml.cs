using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using business_mobile.Models;

namespace business_mobile.TasksView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTask : ContentPage
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void OnAppearing()
        {
            base.OnAppearing();
            Title = "Новая задача";
        }
        private async void TaskAdd_Clicked(object sender, EventArgs e)
        {
            Note note = new Note();
            note.TaskDate = DateTime.Now;
            note.TaskDescription = Convert.ToString(TaskDescription.Text);
            note.TaskID = "";
            //note.UserID = Convert.ToString(App.user.userid); 
            note.TaskName = Convert.ToString(TaskName.Text);

            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}