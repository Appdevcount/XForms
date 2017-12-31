using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Views;
//using XForms.Views.Converters;
using XForms.Views.MVVM;
using XForms.Views.XPlugins;
using XForms.Views.Tabbed;
using XForms.Views.XControls;
using XForms.Views.SfControls;

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

            //MainPage = new NavigationPage( new GenPage("Initial Load"));
            //Your ToolbarItems will not show if your app does not have a Toolbar. The simplest way to add one is to wrap your page in a NavigationPage - 
            //https://stackoverflow.com/questions/25495348/xamarin-forms-toolbar-items-not-displaying-on-view
            //Toolbar won't come for home page by default

            //MainPage = new XamarinForms.SQLite.SQLiteSamplePage().GetSampleContentPage();
            //App thrown an error ""Detected problems with app native libraries(Please consult log for detail)
            //libmonosgen-64bit-2.0.so . unauthorized access to "/system/lib64/libsqlite.so"
            //But still worked after clearing the message

            //MainPage = new GenPage1();

            //MainPage = new CarouselV();

            //MainPage = new MicroCharts();

            //MainPage = new GenPlugins();

            //MainPage = new Communicator();

            //MainPage = new GenPage2();

            //MainPage = new SfGen();

            //MainPage = new SfPDFViewer();

            MainPage = new SfFormUI();
        }
    }
}