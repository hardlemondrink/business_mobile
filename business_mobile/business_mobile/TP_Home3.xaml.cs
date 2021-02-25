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
    public partial class TP_Home3 : ContentPage
    {
        public TP_Home3()
        {
            InitializeComponent();
            GetInfo();
        }
        public string[] tasks { get; set; }
        public void GetInfo()
        {
            taskList.ItemsSource = ServerQuery.Tasks(user.userid, "Done");
        }

        private void taskList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                selected.Text = e.Item.ToString();
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}