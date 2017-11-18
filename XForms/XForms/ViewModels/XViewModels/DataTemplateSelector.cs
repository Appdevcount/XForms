using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XForms.Views.DataTemplate;

namespace XForms.ViewModels.XViewModels
{
    public class MyDataTemplateSelector: DataTemplateSelector
    {
        //Manually override OnSelectTemplate() from DataTemplateSelector class 
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var name = item as string;

            if(name.StartsWith("J"))
            {
                return new DataTemplate(typeof( BigItemViewTemplate));
            }

            return new DataTemplate(typeof(SmallItemViewTemplate));
        }
    }
}
