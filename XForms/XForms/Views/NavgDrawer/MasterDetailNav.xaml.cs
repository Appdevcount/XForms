using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.ViewModels.XViewModels;

namespace XForms.Views.NavgDrawer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailNav : MasterDetailPage
    {
        List<MenuText> Nvgmenus;
        public MasterDetailNav()
        {
            InitializeComponent();

            Nvgmenus.Add(new MenuText { Icon="Web.png",Title= "Web", TargetType=typeof(View1) });
            Nvgmenus.Add(new MenuText { Icon = "Save.png", Title = "Save", TargetType = typeof(View2) });
            Nvgmenus.Add(new MenuText { Icon = "Add.png", Title = "Add", TargetType = typeof(View3) });

            //nvgdrwr.ItemsSource = Nvgmenus;

            //Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(View1)));

            //this.BindingContext = new
            //{
            //    Header="Header",
            //    Image="User.png",
            //    Footer="Footer"
            //};
            
            
        }

        //private void nvgdrwr_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = (MenuText)e.SelectedItem;

        //    Type page = item.TargetType;

        //    Detail = new NavigationPage((Page)Activator.CreateInstance(page));

        //    IsPresented = false;
        //}
    }
}