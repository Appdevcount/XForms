using Syncfusion.SfBusyIndicator.XForms;
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

            //SfBusyIndicator busyIndicator = new SfBusyIndicator();
            //busyIndicator.AnimationType = AnimationTypes.Gear;
            //busyIndicator.ViewBoxWidth = 100;
            //busyIndicator.ViewBoxHeight = 100;
            //busyIndicator.TextColor = Color.PaleVioletRed;
            //this.Content = busyIndicator;

            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Profile");
            list.Add("Inbox");
            list.Add("Out box");
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