using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Views.XControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenPage1 : ContentPage
    {

        List<string> Lstvals = new List<string> { "Apple", "Orange", "Mango", "Jackfruit" };

        public GenPage1()
        {
            InitializeComponent();

            //Lstvw.ItemsSource = Lstvals;
            //LstvwTmpl.ItemsSource = Lstvals;
            LstvwTmpl2.ItemsSource = Lstvals;

            Ddlikeitempkr.Items.Add("Apple");
            Ddlikeitempkr.Items.Add("Orange");
            Ddlikeitempkr.Items.Add("JackFruit");
            Ddlikeitempkr.Items.Add("Mango");
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {

        }

        private void MenuItem_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Ddlikeitempkr_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = Ddlikeitempkr.Items[Ddlikeitempkr.SelectedIndex];
            DisplayAlert("Picker Alert", name, "Ok", "Cancel");
        }


        ////<!--Searchbar - Working with enter key but not working when pressed searchbutton in Android-->
        //private void Srchbar_SearchButtonPressed(object sender, EventArgs e)
        //{
        //    string keyword = Srchbar.Text.ToLower();
        //    IEnumerable<string> Filteredlist = Lstvals.Where(f => f.ToLower().Contains(keyword.ToLower()));
        //    Lstvw.ItemsSource = Filteredlist;
        //    //Lstvw.ItemsSource = Lstvals.Where(f => f.Contains(Srchbar.Text));
        //}


        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    GestGrid.BackgroundColor = Color.Pink;
        //}

    }
}