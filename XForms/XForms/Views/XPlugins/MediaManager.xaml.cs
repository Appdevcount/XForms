using Plugin.MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Views.XPlugins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediaManager : ContentPage
    {
        string Vidurl = "http://video.ch9.ms/ch9/334f/891b78a5-642d-40b4-8d02-ff40ffdd334f/LoginToLinkedinUSingXamarinAuth_mid.mp4";
        string PTLive = "https://www.youtube.com/embed/oQ28k-dHH-E";
        public MediaManager()
        {
            InitializeComponent();
        }

        //private void MediaControl_Clicked(object sender, EventArgs e)
        //{
        //    if (MediaControl.Text == "Play")
        //    {
        //        CrossMediaManager.Current.Play(Vidurl, Plugin.MediaManager.Abstractions.Enums.MediaFileType.Video);
        //        MediaControl.Text = "Stop";
        //        MediaControl.TextColor = Color.Red;
        //    }
        //    else
        //    {
        //        CrossMediaManager.Current.Stop();
        //        MediaControl.Text = "Play";
        //        MediaControl.TextColor = Color.Green;
        //    }
        //}
    }
}