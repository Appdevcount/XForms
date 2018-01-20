using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.MediaManager.Forms.Android;

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

            //Below Initialization for Plugin.Mediamanager media player
            VideoViewRenderer.Init();

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //Added below line for Barcode scanning libraray intialization
            //ZXing.Net.Mobile.Forms.Android.Platform.Init();
            global::ZXing.Net.Mobile.Forms.Android.Platform.Init();


            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            //base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            //Overridden  method and added below line  for Barcode scanning 
            //ZXing.Net.Mobile for Xamarin.Forms also handles the new Android permission request model for you, but you will need to add the following override implementation to your main Activity as well

            global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}