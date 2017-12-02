using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MCEntry = Microcharts.Entry; //This is to differentiate Xamarin.Forms Entry with Microcharts entry and use it

namespace XForms.Views.XPlugins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MicroCharts : ContentPage
    {

        List<MCEntry> MCEntries = new List<MCEntry>
        {
         new MCEntry(200)
            {
            Label = "January",
            ValueLabel = "200",
            Color = SKColor.Parse("#266489")
            },
         new MCEntry(400)
            {
            Label = "February",
            ValueLabel = "400",
            Color = SKColor.Parse("#68B9C0")
            },
         new MCEntry(-100)
            {
            Label = "March",
            ValueLabel = "-100",
            Color = SKColor.Parse("#90D585")
            }

        };

        public MicroCharts()
        {
            InitializeComponent();


            //MChartGen.Chart = new BarChart() { Entries = MCEntries };
            MChart1.Chart = new BarChart() { Entries = MCEntries };
            MChart2.Chart = new PointChart() { Entries = MCEntries };
            MChart3.Chart = new RadialGaugeChart() { Entries = MCEntries };
            MChart4.Chart = new DonutChart() { Entries = MCEntries };
            MChart5.Chart = new LineChart() { Entries = MCEntries };
            MChart6.Chart = new RadarChart() { Entries = MCEntries };

        }
    }
}