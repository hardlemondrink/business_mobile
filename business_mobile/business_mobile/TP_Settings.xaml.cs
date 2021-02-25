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
    public partial class TP_Settings : ContentPage
    {
        public TP_Settings()
        {
            InitializeComponent();
            GetInfo();
        }
        public string[] tasks { get; set; }
        public void GetInfo()
        {
            taskList.ItemsSource = ServerQuery.Tasks(user.userid, "settings");
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