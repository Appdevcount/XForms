using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Views.SfControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SfGen : ContentPage
    {
        public SfGen()
        {
            InitializeComponent();

            List<string> list = new List<string>();
            list.Add("Clothing");
            list.Add("Mobiles");
            list.Add("Fruits");
            list.Add("Vegetables");
            list.Add("Computers");
            list.Add("Furnitures");
            list.Add("Home");
            list.Add("Profile");
            list.Add("Inbox");
            list.Add("Outbox");
            list.Add("Sent");
            list.Add("Draft");
            listView.ItemsSource = list;
        }
        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            
            NavgDrwr.ToggleDrawer();
        }
    }
}