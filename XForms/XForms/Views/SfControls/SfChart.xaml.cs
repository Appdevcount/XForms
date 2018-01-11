using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace XForms.Views.SfControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SfChart : ContentPage
    {
        public SfChart()
        {
            InitializeComponent();

            //SfChart chart = new SfChart();

            ////Initializing Primary Axis
            //CategoryAxis primaryAxis = new CategoryAxis();

            //chart.PrimaryAxis = primaryAxis;

            ////Initializing Secondary Axis
            //NumericalAxis secondaryAxis = new NumericalAxis();

            //chart.SecondaryAxis = secondaryAxis;

            //this.Content = chart;

            if (!(Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS))
            {
                Chart.Series[0].AnimationDuration = 2;
                (Chart.Series[0] as PieSeries).StartAngle = 0;
                (Chart.Series[0] as PieSeries).EndAngle = 360;
            }

            if (Device.OS == TargetPlatform.Windows || Device.OS == TargetPlatform.iOS ||
               Device.OS == TargetPlatform.WinPhone)
            {
                DataMarkerLabelStyle style = new DataMarkerLabelStyle();
                style.Margin = new Thickness(3, 2, 3, 2);
                dataMarker.LabelStyle = style;
            }

        }
    }

    public class ChartData
    {
        public ChartData(string category, double value)
        {

            this.Category = category;

            this.Value = value;
            
        }

        public string Category { get; set; }

        public double Value { get; set; }
    }

    public class DataModel
    {
        public ObservableCollection<ChartData> ChartDataModel { get; set; }

        //2nd ObservableCollection added for column sharts specifically
        public ObservableCollection<ChartData> ColumnData1 { get; set; }

        public DataModel()
        {
            ChartDataModel = new ObservableCollection<ChartData>();

            ChartDataModel.Add(new ChartData("Fruits", 42 ));
            ChartDataModel.Add(new ChartData("Vegs", 44 ));
            ChartDataModel.Add(new ChartData("Meat", 53 ));
            ChartDataModel.Add(new ChartData("Furniture", 64 ));
            ChartDataModel.Add(new ChartData("Electronics", 75 ));
            ChartDataModel.Add(new ChartData("Utensils", 83 ));

            ColumnData1 = new ObservableCollection<ChartData>
            {
                new ChartData("USA", 50),
                new ChartData("China", 40),
                new ChartData("Japan", 70),
                new ChartData("Australia", 60),
                new ChartData("France", 50)
           };

        }

    }
}