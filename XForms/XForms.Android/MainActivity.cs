using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace XForms.Droid
{
    [Activity(Label = "XForms.Android", 
        Icon = "@drawable/XamApp", 
        Theme = "@style/MyTheme", 
        MainLauncher = false, //MainLauncher is responsible for making this activity the first activity to show 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    //Changed MainLauncher = false, to not have this class as startup 
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //Added below line for Xam.Plugin.Media intialization for platforms separately,
            //since its async method call , added await and async to this calling parent menthod
            await Plugin.Media.CrossMedia.Current.Initialize();

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }
    }
}