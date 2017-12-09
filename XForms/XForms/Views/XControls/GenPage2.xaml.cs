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
    public partial class GenPage2 : ContentPage
    {
        List<string> FullList = new List<string> { "Red", "Blue", "Orange" ,"Green","Brown"
                ,"Magenta","Navy","Yellow","Violet","Black","White"};
        public GenPage2()
        {
            InitializeComponent();
        }

        private void SBar_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Selected Item", SBar.Text, "Cancel pannava?");
        }

        private void SBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var suggestionlist = FullList.Where(c => c.ToLower().Contains(e.NewTextValue.ToLower()));
            SuggestionList.ItemsSource = suggestionlist;

        }

        private void SuggestionList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var SelectedIteminList = e.Item as string;
            DisplayAlert("Selected Item", SelectedIteminList, "Cancel pannava?");
        }
    }
}