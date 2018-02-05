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
    public partial class GenPage : ContentPage
    {
        public GenPage()//string GenPageParam)
        {
            InitializeComponent();
            //GPagelbl.Text = GenPageParam;
        }

        protected override async void OnAppearing()
        //Overriding the OnAppearing of ContentPage just for the purpose of displaying the GRADUAL PROGRESS MOTION IN BAR  status in label
        {
            base.OnAppearing();

            //await Uploadprogressor.ProgressTo(0.8, 10000, Easing.Linear);
        }

        //Alert option to accept or reject
        private void DisplaySaveAlert_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Permission Title", "Do you want to save?", "Save", "No");//From ContentPage class
            GPagelbl.Text = FName.Text;
        }

        //Popup menu option
        private async void DisplayActionSheet_Clicked(object sender, EventArgs e)
        {
            string[] Colors = { "Blue", "Green", "Yellow" };
            string color = await DisplayActionSheet("ActionSheet", "Cancel", "Destroy", Colors);

            switch (color)
            {
                case "Blue":
                    BackgroundColor = Color.Blue;
                    break;
                case "Green":
                    BackgroundColor = Color.Green;
                    break;
                case "Yellow":
                    BackgroundColor = Color.Yellow;
                    break;
                default:
                    BackgroundColor = Color.Pink;
                    break;
            }

        }

        //Price Slider
        private void PriceSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderLbl.Text = PriceSlider.Value.ToString();
        }

        //ToolbarItem menu Item click
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            string Dateselected = e.NewDate.ToString();
            string PrevDateselected = e.OldDate.ToString();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            string isToggled = e.Value.ToString();//Boolean to string

        }
    }
}