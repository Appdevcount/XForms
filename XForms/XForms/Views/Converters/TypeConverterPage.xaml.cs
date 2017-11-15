using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Views.Converters
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TypeConverterPage : ContentPage
	{
		public TypeConverterPage ()
		{
			InitializeComponent();
		}

        private void ConvertColor_Clicked(object sender, EventArgs e)
        {
            //ColorLbl.Text = ColKeywd.Text;
        }
    }
}