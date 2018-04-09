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
    public partial class SfMultiControlTabPage : ContentPage
    {
        public SfMultiControlTabPage()
        {
            InitializeComponent();
            //var tabView = new SfTabView();
            //var allContactsGrid = new Grid { BackgroundColor = Color.Red };
            //var favoritesGrid = new Grid { BackgroundColor = Color.Green };
            //var contactsGrid = new Grid { BackgroundColor = Color.Blue };
            //var tabItems = new TabItemCollection
            //{
            //new SfTabItem()
            //    {
            //    Title = "Calls",
            //    Content = allContactsGrid
            //    },
            //new SfTabItem()
            //    {
            //    Title = "Favorites",
            //    Content = favoritesGrid
            //    },
            //new SfTabItem()
            //    {
            //    Title = "Contacts",
            //    Content = contactsGrid
            //    }
            //};

            //tabView.Items = tabItems;
            //this.Content = tabView;


            //SfBusyIndicator busyIndicator = new SfBusyIndicator();
            //busyIndicator.IsBusy = true;

            //this.Content = busyIndicator;


            //busyindicator1.IsVisible = true;
            //busyindicator1.IsBusy = true;

            //busyindicator1.IsVisible = false;
            //busyindicator1.IsBusy = false;
        }

        private async void StartAnimate1_Clicked(object sender, EventArgs e)
        {

            //busyindicator1.IsVisible = true;
            //busyindicator1.IsBusy = true;

            ////simulated delay for 10 seconds
            //var startDt = DateTime.Now;
            //while (true)
            //{
            //    if ((DateTime.Now - startDt).TotalSeconds >= 10)
            //        break;
            //}
            //Resultlbl.Text = "Details Received"+DateTime.Now;

            ////busyindicator1.IsVisible = false;
            ////busyindicator1.IsBusy = false;

            //Syncfussion busy indicator doesn't help much with button click

            StartAnimate1.IsEnabled = false;

            ActivityIndicator indicator = new ActivityIndicator { IsRunning = true, IsVisible = true, Color = Color.Purple};

            SfBusyIndicator sfbi = new SfBusyIndicator { IsBusy = true, IsEnabled = true, IsVisible = true, TextColor = Color.Purple,AnimationType=AnimationTypes.Gear };

            Lottie.Forms.AnimationView LA = new Lottie.Forms.AnimationView { Animation = "Lottie_preloader.json", Loop = true, AutoPlay = true, IsEnabled = true, IsVisible = true, IsPlaying = true };


            //SL.Children.Add(indicator);
            //SL.Children.Add(sfbi);
            SL.Children.Add(LA);
            await Task.Delay(7000);
            Resultlbl.Text = "Details Received" + DateTime.Now;
            indicator.IsRunning = false;
            indicator.IsVisible = false;
            sfbi.IsVisible = false;
            sfbi.IsEnabled = true;
            sfbi.IsBusy = false;
            LA.IsEnabled = false;
            LA.IsVisible = false;
            LA.IsPlaying = false;

            StartAnimate1.IsEnabled = true;
        }
    }
}