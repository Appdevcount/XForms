using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinForms.SQLite;
using XamarinForms.SQLite.SQLite;

namespace XForms.Views.SQLiteViews
{
    public class SQLiteCRUD : ContentPage
    {
        private readonly SQLiteConnection _sqLiteConnection;


        public SQLiteCRUD()
        {
            #region SQLiteDBInitialization

            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

            _sqLiteConnection.CreateTable<TodoItem>();

            // ADD
            _sqLiteConnection.Insert(new TodoItem
            {
                Text = "Tutorial about SQLite" + System.DateTime.Now.ToString(),
                Done = false,
            });

            // UPDATE
            _sqLiteConnection.Update(new TodoItem
            {
                ID = 1,
                Text = "Creating a tutorial about SQLite" + System.DateTime.Now.ToString(),
                Done = true,
            });


            _sqLiteConnection.Insert(new TodoItem
            {
                Text = "Meeting Friends at 11 AM" + System.DateTime.Now.ToString(),
                Done = true,
            });

            // DELETE
            _sqLiteConnection.Delete<TodoItem>(2);

            #endregion SQLiteDBInitialization


            #region ContentPageCreation
            Entry entry = new Entry
            {
                Placeholder = "Text",
                WidthRequest = Device.OnPlatform<double>(300, 300, 260)
            };

            Switch switcher = new Switch();

            Button addButton = new Button
            {
                Text = "Add TodoItem"
            };
            addButton.Clicked += (s, e) =>
            {
                _sqLiteConnection.Insert(new TodoItem
                {
                    Text = entry.Text,
                    Done = switcher.IsToggled,
                });
            };
            Button DeleteButton = new Button
            {
                Text = "Delete 1st TodoItems"
            };
            DeleteButton.Clicked += DeleteButton_Clicked;
            Button DeleteAllButton = new Button
            {
                Text = "Delete All TodoItems"
            };
            DeleteAllButton.Clicked += DeleteAllButton_Clicked;
            ListView listView = new ListView
            {
                ItemsSource = _sqLiteConnection.Table<TodoItem>()
            };

            Button refreshButton = new Button
            {
                Text = "Refresh TodoItems"
            };
            refreshButton.Clicked += (s, e) =>
            {
                listView.ItemsSource = _sqLiteConnection.Table<TodoItem>();
            };
            Content =new ScrollView
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "SQLite Sample",
                            FontSize = 50
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                entry,
                                switcher,
                            }
                        },
                        addButton,
                        DeleteButton,
                        DeleteAllButton,
                        refreshButton,
                        listView,
                    }
                }
            };
            #endregion ContentPageCreation
        }

        private void DeleteAllButton_Clicked(object sender, EventArgs e)
        {
            _sqLiteConnection.DeleteAll<TodoItem>();
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            _sqLiteConnection.Delete<TodoItem>(3);
        }
    }
}
