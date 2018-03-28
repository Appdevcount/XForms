using Plugin.Media;
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
	public partial class GenPlugins : ContentPage
	{
		public GenPlugins ()
		{
			InitializeComponent();

            Applechkbx.Checked = true;
            Applechkbx.IsEnabled = false;
        }

		private async void  TakePhoto_Clicked(object sender, EventArgs e)
		{
			await CrossMedia.Current.Initialize();

			if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
			{
				DisplayAlert("No Camera", ":( No camera available.", "OK");
				return;
			}

			var file = await CrossMedia.Current.TakePhotoAsync(new   Plugin.Media.Abstractions.StoreCameraMediaOptions
			{
				Directory = "XForms",
				Name = "test.jpg",
				SaveToAlbum =true
			});

			if (file == null)
				return;

			await DisplayAlert("File Location", file.Path, "OK");

			await DisplayAlert("File Location", file.Path+" == "+file.AlbumPath, "OK");

			FilePath.Text = file.AlbumPath;


			PicDisplay.Source = ImageSource.FromStream(() =>
			{
				var stream = file.GetStream();
				file.Dispose();
				return stream;
			});

			//PicDisplay.Source = file.Path;

			//or:
			//image.Source = ImageSource.FromFile(file.Path);
			//image.Dispose();

		}

		private async void PickPhoto_Clicked(object sender, EventArgs e)
		{
			await CrossMedia.Current.Initialize();

			if (!CrossMedia.Current.IsPickPhotoSupported)
			{
				DisplayAlert("Oops", ":( Pick photo is not supported! ", "OK");
				return;
			}

			var file = await CrossMedia.Current.PickPhotoAsync();

			if (file == null)
				return;

			await DisplayAlert("File Location", file.Path, "OK");
			await DisplayAlert("File Location", file.Path + " == " + file.AlbumPath, "OK");

			FilePath.Text = file.AlbumPath;


			PicDisplay.Source = ImageSource.FromStream(() =>
			{
				var stream = file.GetStream();
				file.Dispose();
				return stream;
			});

			//PicDisplay.Source = file.Path;

			//or:
			//image.Source = ImageSource.FromFile(file.Path);
			//image.Dispose();

		}

		private async void TakeVideo_Clicked(object sender, EventArgs e)
		{
			await CrossMedia.Current.Initialize();

			if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakeVideoSupported)
			{
				DisplayAlert("No Camera", ":( No camera available.", "OK");
				return;
			}

			var file = await CrossMedia.Current.TakeVideoAsync(new Plugin.Media.Abstractions.StoreVideoOptions
			{
				Directory = "XForms",
				Name = "test.jpg",
				SaveToAlbum=true,
				 Quality=Plugin.Media.Abstractions.VideoQuality.High

			});

			if (file == null)
				return;

			await DisplayAlert("File Location", file.Path, "OK");

			FilePath.Text = file.AlbumPath;


			PicDisplay.Source = ImageSource.FromStream(() =>
			{
				var stream = file.GetStream();
				file.Dispose();
				return stream;
			});

			//PicDisplay.Source = file.Path;


			//or:
			//image.Source = ImageSource.FromFile(file.Path);
			//image.Dispose();

		}

		private async void PickVideo_Clicked(object sender, EventArgs e)
		{
			await CrossMedia.Current.Initialize();

			if (!CrossMedia.Current.IsPickVideoSupported)
			{
				DisplayAlert("No Camera", ":( No camera available.", "OK");
				return;
			}

			var file = await CrossMedia.Current.PickVideoAsync();

			if (file == null)
				return;

			await DisplayAlert("File Location", file.Path, "OK");

			FilePath.Text = file.AlbumPath;


			PicDisplay.Source = ImageSource.FromStream(() =>
			{
				var stream = file.GetStream();
				file.Dispose();
				return stream;
			});

			//PicDisplay.Source = file.Path;

			//or:
			//image.Source = ImageSource.FromFile(file.Path);
			//image.Dispose();

		}
	}
}