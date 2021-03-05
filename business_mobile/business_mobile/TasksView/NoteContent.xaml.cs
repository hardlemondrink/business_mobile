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
    public partial class NoteContent : ContentPage
    {
        private Note note;
        public NoteContent(Note task)
        {
            InitializeComponent();
            note = task;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var selectedTask = note;
            Label taskName = new Label
            {
                Text = selectedTask.TaskName
            };

            Label taskID = new Label
            {
                Text = selectedTask.TaskID
            };

            Label taskDescription = new Label
            {
                Text = selectedTask.TaskDescription
            };

            Label taskDate = new Label
            {
                Text = selectedTask.TaskDate.ToString()
            };

            StackLayout stackLayout = new StackLayout
            {
                Padding = 30,
                Children =
                {
                    taskName,
                    taskDescription,
                    taskID,
                    taskDate
                }
            };

            this.Content = stackLayout;
        }
    }
}