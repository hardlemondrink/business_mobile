using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using business_mobile.TasksView;
using business_mobile.Models;

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
                //selected.Text = e.Item.ToString();
                ((ListView)sender).SelectedItem = null;
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Label header = new Label
            {
                Text = "Новые задачи",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            var result = await App.Database.GetNotesAsync();
            //taskList.ItemsSource = result;

            List<Note> listNotes = new List<Note>();

            foreach (Note note in result)
            {
                listNotes.Add(note);
            }

            Button taskAdd = new Button();
            taskAdd.Clicked += Button_Clicked;
            taskAdd.Text = "Добавить";
            taskAdd.HorizontalOptions = LayoutOptions.Center;
            //taskAdd.BackgroundColor = Color.Aquamarine;
            
            ListView listView = new ListView
            {
                ItemsSource = listNotes,
                ItemTemplate = new DataTemplate(() =>
                {
                    Label taskName = new Label();
                    taskName.SetBinding(Label.TextProperty, "TaskName");

                    Label taskDate = new Label();
                    taskDate.SetBinding(Label.TextProperty, new Binding("TaskDate", BindingMode.OneWay, null, null, "Create {0:d}", null));

                    //BoxView boxView = new BoxView();
                    //boxView.SetBinding(BoxView.ColorProperty, Color.Blue);

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                //boxView,
                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 0,
                                    Children =
                                    {
                                        taskName,
                                        taskDate
                                    }
                                }
                            }
                        }
                    };

                })
            };

            AbsoluteLayout floatingButton = new AbsoluteLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                Children =
                {
                    taskAdd
                }
            };

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    listView,
                    floatingButton
                }
            };

            this.Content = stackLayout;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTask());
        }
    }
}