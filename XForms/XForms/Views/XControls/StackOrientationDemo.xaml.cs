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
    public partial class StackOrientationDemo : ContentPage
    {
        public StackOrientationDemo()
        {
            InitializeComponent();
        }


        //Some C# is used to change the orientation of outerStack based on the orientation of the device:
        //Note that the OnSizeAllocated method may be called many times when a device is rotated.Changing your layout each time is wasteful of resources and can lead to flickering.Consider using an instance variable within your page to track whether the orientation is in landscape or portrait, and only redraw when there is a change:
        private double width = 0;
        private double height = 0;
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                if (width > height)
                {
                    outerStack.Orientation = StackOrientation.Horizontal;
                }
                else
                {
                    outerStack.Orientation = StackOrientation.Vertical;
                }
            }
        }
    }
}