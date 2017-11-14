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
	public partial class MenuPage : MasterDetailPage //Cahnged Page partial classtype from Content page to MasterDetailPage
    {
		public MenuPage ()
		{
			InitializeComponent ();
		}
	}
}