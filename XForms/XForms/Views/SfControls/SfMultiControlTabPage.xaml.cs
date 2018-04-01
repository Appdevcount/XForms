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
        }
    }
}