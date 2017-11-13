using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //if (Device.RuntimePlatform == Device.iOS)
            //    MainPage = new MainPage();
            //else
            //    MainPage = new NavigationPage(new MainPage());

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new Home();
            else
                MainPage = new NavigationPage(new Home());

        }
    }
}