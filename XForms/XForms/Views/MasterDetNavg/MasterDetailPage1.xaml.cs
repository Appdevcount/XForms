﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.SQLite;
using XForms.Views.SfControls;
using XForms.Views.Tabbed;
using XForms.Views.XControls;
using XForms.Views.XPlugins;

namespace XForms.Views.MasterDetNavg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;


            page.Icon = "Web.png";

            //For testing purpose -Checking Tabbed detail page
            if (page.GetType().Name.Equals(new CarouselV().GetType().Name))//page.Equals(new CarouselV() { Title = item.Title })) //(Page)Activator.CreateInstance(typeof(CarouselV)))
            {
                CarouselV c = new CarouselV() { Title = item.Title };
                //DisplayAlert("", page.GetType().Name, "Cancel");
                //DisplayAlert("", c.GetType().Name, "Cancel");
                //DisplayAlert("", page.GetType().Name.Equals(new CarouselV().GetType().Name).ToString(), "Cancel");
                Detail = new NavigationPage(
                    new TabbedPage
                    {
                        Children =
                        {
                        new CarouselV(){ Title="Carousel" ,Icon="Web.png"},
                        new SnfDataGrid(){ Title="SnfDataGrid" }//,Icon="save.png"}
                           }
                    });
            }
            else if (page.GetType().Name.Equals(new GenPage().GetType().Name))
            {
                Detail = new NavigationPage(
                    new TabbedPage
                    {
                        Children =
                        {
                        new GenPage(){ Title="GenPage" ,Icon="Web.png"},
                        new GenPage1(){ Title="GenPage1" },
                        new GenPage2(){ Title="GenPage2" }//,Icon="save.png"}
                           }
                    });
            }
            else if (page.GetType().Name.Equals(new StackLayoutDemo().GetType().Name))
            {
                Detail = new NavigationPage(
                    new TabbedPage
                    {
                        Children =
                        {
                        new StackLayoutDemo(){ Title="StackLayoutDemo" ,Icon="Web.png"},
                        new XControls.LayoutOptions(){ Title="LayoutOptions" },
                        new StackOrientationDemo(){ Title="StackOrientationDemo" },//,Icon="save.png"}
                        new GridOrientationDemo(){ Title="GridOrientationDemo" }//,Icon="save.png"}
                           }
                    });

            }
            else if (page.GetType().Name.Equals(new SfFormUI().GetType().Name))
            {
                Detail = new NavigationPage(
                    new TabbedPage
                    {
                        Children =
                        {
                        new SfFormUI(){ Title="UI" ,Icon="Web.png"},
                        new SfPDFViewer(){ Title="PDF" },
                        new SfGen(){ Title="SfGen" },//,Icon="save.png"}
                        new SnfChart(){ Title="Chart" },//,Icon="save.png"}
                        new SfMultiControlTabPage(){ Title="MultiControl" },//,Icon="save.png"}
                    new SnfDataGrid {  Title = "DataGrid" }

                    }
                    });

            }
            else
            {
                CarouselV c = new CarouselV() { Title = item.Title };
                //DisplayAlert("", page.GetType().Name, "Cancel");
                //DisplayAlert("", c.GetType().Name, "Cancel");
                //DisplayAlert("", page.GetType().Name.Equals(new CarouselV().GetType().Name).ToString(), "Cancel");
                //Detail = new NavigationPage(
                //    new TabbedPage
                //    {
                //        Children =
                //        {
                //            page,
                //            new GenPage()//"Tabbed Page Load")
                //        }

                //    });


                Detail = new NavigationPage(page);
            }

            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}