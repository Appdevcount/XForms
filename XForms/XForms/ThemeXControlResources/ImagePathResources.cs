using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XForms.ThemeXControlResources
{
    public static class ImagePathResources
    {
        public static readonly string BackgroundImagePath = Device.OnPlatform("rainBus320.jpg", "rainBus.jpg", "rainBus.jpg");
    }
}
