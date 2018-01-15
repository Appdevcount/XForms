using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.DAL;

namespace XForms.Views.XControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GListView : ContentPage
    {
        public GListView()
        {
            InitializeComponent();

            //List<string> Fruitstr = new List<string>
            //{
            //    "Apple","Orange","JackFruit","Mango","Banana"
            //};

            //LVstring.ItemsSource = Fruitstr;

            //Rendering both these 2 listviews at the same time causes error in building the project.  Error - Sequence contains no elements


            Fruits f = new Fruits();

            LVobject.ItemsSource = f.FruitList();
            
        }
    }
}