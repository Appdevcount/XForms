﻿using SQLite;
using Xamarin.Forms;
using XamarinForms.SQLite.SQLite;

namespace XamarinForms.SQLite
{
    //Not used this file for explicitly preparing POC for SQLite ,so refer SQLiteCRUD content page in SQLiteViews folder to learn about SQLite concepts
    public class SQLiteSamplePage
    {
        private readonly SQLiteConnection _sqLiteConnection;

        public SQLiteSamplePage()
        {

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
                Text = "Meeting Friends at 11 AM" +System.DateTime.Now.ToString(),
                Done = true,
            });

            // DELETE
            _sqLiteConnection.Delete<TodoItem>(2);
        }

        /// <summary>
        /// Gets a ContentPage that contains the items saved in the SQLite database.
        /// </summary>
        /// <returns></returns>
        public ContentPage GetSampleContentPage()
        {

            var entry = new Entry
            {
                Placeholder = "Text",
                WidthRequest = Device.OnPlatform<double>(300, 300, 260)
            };

            var switcher = new Switch();

            var addButton = new Button
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

            var listView = new ListView
            {
                ItemsSource = _sqLiteConnection.Table<TodoItem>()
            };

            var refreshButton = new Button
            {
                Text = "Refresh TodoItems"
            };
            refreshButton.Clicked += (s, e) =>
            {
                listView.ItemsSource = _sqLiteConnection.Table<TodoItem>();
            };

            var contentPage = new ContentPage
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
                        refreshButton,
                        listView,
                    }
                }
            };
            return contentPage;
        }
    }
}
