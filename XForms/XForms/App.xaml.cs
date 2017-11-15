using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Views;
//using XForms.Views.Converters;
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

            //MainPage = new BindedPage();

            //MainPage = new Views.MVVM.TwoWayBindedPage();

            //MainPage = new Views.Converters.TypeConverterPage();//Refer TwoWayBindedPage for this demo. This one remved from project

            //MainPage = new Views.XControls.OnPlatform();

            //MainPage = new CrossPieCharts.FormsPlugin.Abstractions.CrossPieChartSample().GetPageWithPieChart();//Call the method of auto implemented sample class to display chart 
            //The smaller charts not appearing fully horizontally.Its truncated

            MainPage = new GenPage("Initial Load");


        }
    }
}