using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XForms.Models.XModel
{
    public class TextToColorConverter : IValueConverter // For custom Type converters implement this IValueConverterintefrace and implement its method according to need to return desired value/change on converting
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)//Method definition implemented according to need as the parameter and return type are generic 
        {
            if(value!=null)
            {
                var Text = value.ToString();
                if (Text.Contains("UI"))
                {
                    return Color.Tomato;
                }
            }

            return Color.Yellow;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
