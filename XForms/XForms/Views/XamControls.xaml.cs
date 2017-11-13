using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamControls : ContentPage
    {
        public XamControls(string PageParameter)
        {
            InitializeComponent();
            PageParamLbl.Text = PageParameter;
        }
    }
}