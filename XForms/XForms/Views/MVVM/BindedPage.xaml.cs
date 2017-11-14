using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.ViewModels.XViewModels;

namespace XForms.Views.MVVM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BindedPage : ContentPage
	{
		public BindedPage ()
		{
			InitializeComponent ();

            BindingContext = new PersonViewModel();//View Model object Binded to the context
		}
	}
}