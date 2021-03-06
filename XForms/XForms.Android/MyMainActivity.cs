﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XForms.Droid
{
    [Activity(Label = "Android App",
        Theme ="@style/Theme.Splash",
        MainLauncher =true, //MainLauncher is responsible for making this activity the first activity to show 
        NoHistory = true //NoHistory is responsible for preventing navigation back to this activity
        )]
    //This custom class is implemented for intial splash screen using image addsign in @drawable folder
    public class MyMainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
            // Create your application here
        }
    }
}