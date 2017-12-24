using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.ViewModels.XViewModels;

namespace XForms.Views.SfControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SfGen : ContentPage
    {
        public List<MenuText> menuList { get; set; } //View model for Menu-Icon combination

        public SfGen()
        {
            InitializeComponent();

            //Below one for default Syncfussion navigation drawer menu item
            //List<string> list = new List<string>();
            //list.Add("Clothing");
            //list.Add("Mobiles");
            //list.Add("Fruits");
            //list.Add("Vegetables");
            //list.Add("Computers");
            //list.Add("Furnitures");
            //list.Add("Home");
            //list.Add("Profile");
            //list.Add("Inbox");
            //list.Add("Outbox");
            //list.Add("Sent");
            //list.Add("Draft");
            //navigationDrawerList.ItemsSource = list;

            //Below one for Menu-Text combination navigation drawer menu item
            menuList = new List<MenuText>();
            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MenuText() { Title = "Item 1", Icon = "Add.png", TargetType = typeof(SfFormUI) };
            var page2 = new MenuText() { Title = "Item 2", Icon = "Save.png", TargetType = typeof(SfFormUI) };
            var page3 = new MenuText() { Title = "Item 3", Icon = "Web.png", TargetType = typeof(SfFormUI) };
            var page4 = new MenuText() { Title = "Item 4", Icon = "Camera.png", TargetType = typeof(SfFormUI) };
            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

        }
        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            
            NavgDrwr.ToggleDrawer();
        }

        private async void  navigationDrawerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuText)e.SelectedItem;
            Type page = item.TargetType;

            //if(  (SfFormUI)Activator.CreateInstance(page) == new SfFormUI())
            if ( object.ReferenceEquals( (SfFormUI)Activator.CreateInstance(page) , new SfFormUI()))
            {
                NavgDrwr.ContentView = new SfFormUI().Content;
                contentLabel.Text = "(Page)Activator.CreateInstance(page) == new SfFormUI() TRUE ";
            }
            else
            {
                NavgDrwr.ContentView = new SfFormUI().Content;
                //contentLabel.Text = object.ReferenceEquals((SfFormUI)Activator.CreateInstance(page), new SfFormUI()) +
                //    ((SfFormUI)Activator.CreateInstance(page) == new SfFormUI()).ToString() + 
                //    "(Page)Activator.CreateInstance(page) == new SfFormUI() false";

               //await Navigation.PushAsync((Page)Activator.CreateInstance(page));
                await Navigation.PushAsync(new SfFormUI());

                //View v;
                //v.BackgroundColor = Color.Green;

                //Content.t

                //NavgDrwr.ContentView = v;
            }
            
            ////Navigation.PushAsync((Page)Activator.CreateInstance(page));

            //Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            //IsPresented = false;
            
        }
    }
}