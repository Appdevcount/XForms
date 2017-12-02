using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Views.XPlugins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselV : ContentPage
    {
        public CarouselV()
        {
            InitializeComponent();

            //List<string> CarouselViewSource = new List<string>
            //{
            //    "A","B","C","D"
            //};

            List<string> CarouselViewSource = new List<string>
            {
                "http://wowslider.com/sliders/demo-93/data1/images/sunset.jpg","Carousel2.jpg","Carousel1.jpg","Carousel3.jpg","Carousel4.jpg"
            };

            XCarouselV.ItemsSource = CarouselViewSource;

        }

        private void XCarouselV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ActveCaroselView.Text = e.SelectedItem as string;
        }
    }
}