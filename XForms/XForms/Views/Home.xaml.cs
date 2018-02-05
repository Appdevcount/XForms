using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Views.XControls;

namespace XForms.Views                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()                                                                                                                       
        {
            InitializeComponent();
            Title = "Home Title";
        }

        private void Display_Clicked(object sender, EventArgs e)
        {
            Displaylbl.Text ="Entered Name is "+ FName.Text;
        }

        private async void Navigate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GenPage());//"Test param from Home"));
        }
    }
}