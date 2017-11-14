using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.ViewModels.XViewModels;

namespace XForms.Views.MVVM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TwoWayBindedPage : ContentPage 
    {
		public TwoWayBindedPage()
		{
			InitializeComponent();

            BindingContext = new PersonViewModel();//View Model object Binded to the context
		}


    }
}