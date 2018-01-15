using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace XForms.Views.LibraryPOCs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarcodeScanner : ContentPage
    {
        public BarcodeScanner()
        {
            InitializeComponent();
        }

        private async void ScanBrcde_Clicked(object sender, EventArgs e)
        {
           

            try
            {
                //setup options
                var options = new MobileBarcodeScanningOptions
                {
                    AutoRotate = false,
                    UseFrontCameraIfAvailable = false,
                    TryHarder = true,
                    //PossibleFormats = new List<ZXing.BarcodeFormat> //This will restrict reading only specific barcode types
                    //{
                    //    ZXing.BarcodeFormat.EAN_8,
                    //    ZXing.BarcodeFormat.EAN_13
                    //}
                };

                ZXingScannerPage scanPage = new ZXingScannerPage(options)
                {
                    DefaultOverlayTopText = "Align the barcode within the frame",
                    DefaultOverlayBottomText = "Scan the Barcode",
                    DefaultOverlayShowFlashButton = true
                };
                scanPage.OnScanResult += (result) =>
                {
                    scanPage.IsScanning = false;

                    ZXing.BarcodeFormat barcodeFormat = result.BarcodeFormat;
                    string type = barcodeFormat.ToString();
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Navigation.PopAsync();
                        DisplayAlert("The Barcode type is : " + type, "The text is : " + result.Text, "OK");

                    });
                };

                await Navigation.PushAsync(scanPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Exception", ex.Message.ToString() , "Ok");
                //+(!string.IsNullOrEmpty(ex.InnerException.Message.ToString()) ? ex.InnerException.Message : "")
            }
        }
    }
}