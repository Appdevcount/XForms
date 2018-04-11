using Syncfusion.SfBusyIndicator.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.API;

namespace XForms.Views.APIView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReqRes : ContentPage
    {
        public ReqRes()
        {
            InitializeComponent();


        }
        DataAccess da = new DataAccess();
        string Res;

        private async void GetAll_Clicked(object sender, EventArgs e)
        {
            GetAll.IsEnabled = false;

            ActivityIndicator indicator = new ActivityIndicator { IsRunning = true, IsVisible = true, Color = Color.Purple };

            SfBusyIndicator sfbi = new SfBusyIndicator { IsBusy = true, IsEnabled = true, IsVisible = true, TextColor = Color.Purple, AnimationType = AnimationTypes.Gear };

            Lottie.Forms.AnimationView LA = new Lottie.Forms.AnimationView { Animation = "Lottie_preloader.json", Loop = true, AutoPlay = true, IsEnabled = true, IsVisible = true, IsPlaying = true };


            //SL.Children.Add(indicator);
            //SL.Children.Add(sfbi);
            SL.Children.Add(LA);
            
            GetAll.IsEnabled = true;

            Res = await da.findAll();
            //Res = Res.Replace('"', ' ').Substring(0, Res.Length - 1);
            ResponseLabel.Text = (Res == "" | Res == null) ? "No Data GetAll" : Res;

            indicator.IsRunning = false;
            indicator.IsVisible = false;
            sfbi.IsVisible = false;
            sfbi.IsEnabled = true;
            sfbi.IsBusy = false;
            LA.IsEnabled = false;
            LA.IsVisible = false;
            LA.IsPlaying = false;

        }

        private void Get_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator indicator = new ActivityIndicator { IsRunning = true, IsVisible = true, Color = Color.Purple };

            SfBusyIndicator sfbi = new SfBusyIndicator { IsBusy = true, IsEnabled = true, IsVisible = true, TextColor = Color.Purple, AnimationType = AnimationTypes.Gear };

            Lottie.Forms.AnimationView LA = new Lottie.Forms.AnimationView { Animation = "Lottie_preloader.json", Loop = true, AutoPlay = true, IsEnabled = true, IsVisible = true, IsPlaying = true };


            //SL.Children.Add(indicator);
            //SL.Children.Add(sfbi);
            SL.Children.Add(LA);

            Res = da.find(1);
            //Res =Res.Replace('"', ' ').Substring(0, Res.Length-1);
            ResponseLabel.Text = (Res == "" | Res == null) ? "No Data Get" : Res;

            indicator.IsRunning = false;
            indicator.IsVisible = false;
            sfbi.IsVisible = false;
            sfbi.IsEnabled = true;
            sfbi.IsBusy = false;
            LA.IsEnabled = false;
            LA.IsVisible = false;
            LA.IsPlaying = false;

        }



        private void Create_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator indicator = new ActivityIndicator { IsRunning = true, IsVisible = true, Color = Color.Purple };

            SfBusyIndicator sfbi = new SfBusyIndicator { IsBusy = true, IsEnabled = true, IsVisible = true, TextColor = Color.Purple, AnimationType = AnimationTypes.Gear };

            Lottie.Forms.AnimationView LA = new Lottie.Forms.AnimationView { Animation = "Lottie_preloader.json", Loop = true, AutoPlay = true, IsEnabled = true, IsVisible = true, IsPlaying = true };


            //SL.Children.Add(indicator);
            //SL.Children.Add(sfbi);
            SL.Children.Add(LA);

            Res = da.Create().ToString();
            ResponseLabel.Text = Res;

            indicator.IsRunning = false;
            indicator.IsVisible = false;
            sfbi.IsVisible = false;
            sfbi.IsEnabled = true;
            sfbi.IsBusy = false;
            LA.IsEnabled = false;
            LA.IsVisible = false;
            LA.IsPlaying = false;

        }

        private void Edit_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator indicator = new ActivityIndicator { IsRunning = true, IsVisible = true, Color = Color.Purple };

            SfBusyIndicator sfbi = new SfBusyIndicator { IsBusy = true, IsEnabled = true, IsVisible = true, TextColor = Color.Purple, AnimationType = AnimationTypes.Gear };

            Lottie.Forms.AnimationView LA = new Lottie.Forms.AnimationView { Animation = "Lottie_preloader.json", Loop = true, AutoPlay = true, IsEnabled = true, IsVisible = true, IsPlaying = true };


            //SL.Children.Add(indicator);
            //SL.Children.Add(sfbi);
            SL.Children.Add(LA);

            Res = da.Edit().ToString();
            ResponseLabel.Text = Res;

            indicator.IsRunning = false;
            indicator.IsVisible = false;
            sfbi.IsVisible = false;
            sfbi.IsEnabled = true;
            sfbi.IsBusy = false;
            LA.IsEnabled = false;
            LA.IsVisible = false;
            LA.IsPlaying = false;

        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator indicator = new ActivityIndicator { IsRunning = true, IsVisible = true, Color = Color.Purple };

            SfBusyIndicator sfbi = new SfBusyIndicator { IsBusy = true, IsEnabled = true, IsVisible = true, TextColor = Color.Purple, AnimationType = AnimationTypes.Gear };

            Lottie.Forms.AnimationView LA = new Lottie.Forms.AnimationView { Animation = "Lottie_preloader.json", Loop = true, AutoPlay = true, IsEnabled = true, IsVisible = true, IsPlaying = true };


            //SL.Children.Add(indicator);
            //SL.Children.Add(sfbi);
            SL.Children.Add(LA);

            ResponseLabel.Text = "No Action configured";

            indicator.IsRunning = false;
            indicator.IsVisible = false;
            sfbi.IsVisible = false;
            sfbi.IsEnabled = true;
            sfbi.IsBusy = false;
            LA.IsEnabled = false;
            LA.IsVisible = false;
            LA.IsPlaying = false;

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator indicator = new ActivityIndicator { IsRunning = true, IsVisible = true, Color = Color.Purple };

            SfBusyIndicator sfbi = new SfBusyIndicator { IsBusy = true, IsEnabled = true, IsVisible = true, TextColor = Color.Purple, AnimationType = AnimationTypes.Gear };

            Lottie.Forms.AnimationView LA = new Lottie.Forms.AnimationView { Animation = "Lottie_preloader.json", Loop = true, AutoPlay = true, IsEnabled = true, IsVisible = true, IsPlaying = true };


            //SL.Children.Add(indicator);
            //SL.Children.Add(sfbi);
            SL.Children.Add(LA);

            Res = da.Delete(2).ToString();
            ResponseLabel.Text = Res;

            indicator.IsRunning = false;
            indicator.IsVisible = false;
            sfbi.IsVisible = false;
            sfbi.IsEnabled = true;
            sfbi.IsBusy = false;
            LA.IsEnabled = false;
            LA.IsVisible = false;
            LA.IsPlaying = false;

        }
    }
}