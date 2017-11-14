using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Views.XControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenPage : ContentPage
    {
        public GenPage(string GenPageParam)
        {
            InitializeComponent();
            GPagelbl.Text = GenPageParam;
        }
    }
}