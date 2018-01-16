using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Views.Tabbed;
using XForms.Views.XControls;
using XForms.Views.XPlugins;

namespace XForms.Views.MasterDetNavg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            //For testing purpose -Checking Tabbed detail page
            if (page.Equals(new CarouselV() { Title = item.Title })) //(Page)Activator.CreateInstance(typeof(CarouselV)))
            {
                Detail = new NavigationPage(
                    new TabbedPage
                    {
                        Children =
                        {
                        new CarouselV(),
                        new GenPage("Tabbed Page Load")
                           }
                    });
            }
            else
            {
                Detail = new NavigationPage(
                    new TabbedPage
                    {
                        Children =
                        {
                            page,
                            new GenPage("Tabbed Page Load")
                        }
                    });
                //Detail = new NavigationPage(page);
            }

            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}