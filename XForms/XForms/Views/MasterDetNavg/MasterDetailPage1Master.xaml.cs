using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Views.LibraryPOCs;
using XForms.Views.SfControls;
using XForms.Views.XControls;
using XForms.Views.XPlugins;

namespace XForms.Views.MasterDetNavg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage1MenuItem> MenuItems { get; set; }

            public MasterDetailPage1MasterViewModel()
            {
                //MenuItems = new ObservableCollection<MasterDetailPage1MenuItem>(new[]
                //{
                //    new MasterDetailPage1MenuItem { Id = 0, Title = "Page 1" },
                //    new MasterDetailPage1MenuItem { Id = 1, Title = "Page 2" },
                //    new MasterDetailPage1MenuItem { Id = 2, Title = "Page 3" },
                //    new MasterDetailPage1MenuItem { Id = 3, Title = "Page 4" },
                //    new MasterDetailPage1MenuItem { Id = 4, Title = "Page 5" },
                //    new MasterDetailPage1MenuItem { Id = 0, Title = "Page 6" },
                //    new MasterDetailPage1MenuItem { Id = 1, Title = "Page 7" },
                //    new MasterDetailPage1MenuItem { Id = 2, Title = "Page 8" },
                //    new MasterDetailPage1MenuItem { Id = 3, Title = "Page 9" },
                //    new MasterDetailPage1MenuItem { Id = 4, Title = "Page 10" }
                //});


                MenuItems = new ObservableCollection<MasterDetailPage1MenuItem>(new[]
                {
                    new MasterDetailPage1MenuItem { Id = 0, Title = "BarcodeScanner",
                    TargetType=typeof(BarcodeScanner)
                    },
                    new MasterDetailPage1MenuItem { Id = 1, Title = "SnfChart" ,
                    TargetType=typeof(SnfChart)
                    },
                    new MasterDetailPage1MenuItem { Id = 2, Title = "SfFormUI",
                    TargetType=typeof(SfFormUI)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "SfPDFViewer" ,
                    TargetType=typeof(SfPDFViewer)
                    },
                    new MasterDetailPage1MenuItem { Id = 4, Title = "SfGen",
                    TargetType=typeof(SfGen)
                    },
                    new MasterDetailPage1MenuItem { Id = 0, Title = "GenPage",
                     TargetType=typeof(GenPage)// Needs param in contructor so it will fail from this listview,when called separately with parameter it will work
                    },
                    new MasterDetailPage1MenuItem { Id = 1, Title = "CarouselV" ,
                     TargetType=typeof(CarouselV)
                    },
                    new MasterDetailPage1MenuItem { Id = 2, Title = "Communicator" ,
                     TargetType=typeof(Communicator)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "GenPage1" ,
                     TargetType=typeof(GenPage1)
                    },
                    new MasterDetailPage1MenuItem { Id = 4, Title = "GenPage2" ,
                     TargetType=typeof(GenPage2)
                    },
                    new MasterDetailPage1MenuItem { Id = 2, Title = "MenuPage" ,
                     TargetType=typeof(MenuPage)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "Styles" ,
                     TargetType=typeof(Styles)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "GenPlugins" ,
                     TargetType=typeof(GenPlugins)
                    },
                    new MasterDetailPage1MenuItem { Id = 4, Title = "MicroCharts" ,
                     TargetType=typeof(MicroCharts)
                    },
                    new MasterDetailPage1MenuItem { Id = 2, Title = "OnPlatform" ,
                     TargetType=typeof(OnPlatform)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "MVVM.TwoWayBindedPage" ,
                     TargetType=typeof(MVVM.TwoWayBindedPage)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "MVVM.BindedPage" ,
                     TargetType=typeof(MVVM.BindedPage)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "SnfDataGrid" ,
                     TargetType=typeof(SnfDataGrid)
                    }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}