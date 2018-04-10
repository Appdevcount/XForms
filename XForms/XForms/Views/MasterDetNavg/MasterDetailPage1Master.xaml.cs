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
using XamarinForms.SQLite;
using XForms.CustomControlsAndBehavior;
using XForms.Views.APIView;
using XForms.Views.LibraryPOCs;
using XForms.Views.SfControls;
using XForms.Views.SQLiteViews;
using XForms.Views.ThemeXControls;
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
                    new MasterDetailPage1MenuItem { Id = 2, Title = "SfControls",
                    TargetType=typeof(SfFormUI)
                    },
                    new MasterDetailPage1MenuItem { Id = 0, Title = "GenPage",
                     TargetType=typeof(GenPage)// Needs param in contructor so it will fail from this listview,when called separately with parameter it will work
                    },
                    new MasterDetailPage1MenuItem { Id = 1, Title = "TabbedCarousel" ,
                     TargetType=typeof(CarouselV)
                    },
                    new MasterDetailPage1MenuItem { Id = 2, Title = "Communicator" ,
                     TargetType=typeof(Communicator)
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
                    new MasterDetailPage1MenuItem { Id = 3, Title = "BindedPage" ,
                     TargetType=typeof(MVVM.BindedPage)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "SnfDataGrid" ,
                     TargetType=typeof(SnfDataGrid)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "MediaManager" ,
                     TargetType=typeof(MediaManager)
                    },
                     new MasterDetailPage1MenuItem { Id = 3, Title = "Layouts" ,
                     TargetType=typeof(XControls.StackLayoutDemo)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "CustomControls" ,
                     TargetType=typeof(CustomEntry)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "ThemeXControls" ,
                     TargetType=typeof(SignUp)
                    },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "APIView" ,
                     TargetType=typeof(ReqRes)
                    },
                     new MasterDetailPage1MenuItem { Id = 3, Title = "SQLiteSamplePage" ,
                     TargetType=typeof(SQLiteCRUD)
                    },
                     new MasterDetailPage1MenuItem { Id = 3, Title = "AnimationPage" ,
                     TargetType=typeof(AnimationPage)
                    },
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