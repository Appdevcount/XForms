using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Views;
using XForms.Views.MVVM;
using XForms.Views.Tabbed;
using XForms.Views.XControls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            #region Actual Main Page snippet
            //if (Device.RuntimePlatform == Device.iOS)
            //    MainPage = new MainPage();
            //else
            //    MainPage = new NavigationPage(new MainPage());
            #endregion

            //if (Device.RuntimePlatform == Device.iOS)
            //    MainPage = new Home();
            //else
            //    MainPage = new NavigationPage(new Home());


            //MainPage = new TabbedPage
            //{
            //    Children =
            //    {
            //        new Home(),
            //        new Tab1Page("Tabbed Page Load")
            //    }
            //};

            //MainPage = new CarouselPage
            //{
            //    Children =
            //    {
            //        new Home(),
            //        new Tab1Page("Tabbed Page Load")
            //    }
            //};

            //MainPage = new Views.XControls.ListView();

            //MainPage = new Views.XControls.MenuPage();

            //MainPage = new Views.XControls.Styles();

            MainPage = new BindedPage();
        }
    }
}