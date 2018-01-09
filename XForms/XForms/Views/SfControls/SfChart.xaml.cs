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

        }
    }

    public class Data
    {
        public Data(string category, double value)
        {

            this.Category = category;

            this.Value = value;
            
        }

        public string Category { get; set; }

        public double Value { get; set; }
    }

    public class DataModel
    {
        public ObservableCollection<Data> ChartData { get; set; }

        public DataModel()
        {
            ChartData = new ObservableCollection<Data>();

            ChartData.Add(new Data("Fruits", 42 ));
            ChartData.Add(new Data("Vegs", 44 ));
            ChartData.Add(new Data("Meat", 53 ));
            ChartData.Add(new Data("Furniture", 64 ));
            ChartData.Add(new Data("Electronics", 75 ));
            ChartData.Add(new Data("Utensils", 83 ));

        }

    }
}