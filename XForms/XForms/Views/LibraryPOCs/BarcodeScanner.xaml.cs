using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Models.Services.LibraryPOCs;
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
            //var scanPage = new ZXingScannerPage();

            ////setup options
            //var options = new MobileBarcodeScanningOptions
            //{
            //    AutoRotate = false,
            //    UseFrontCameraIfAvailable = true,
            //    TryHarder = true,
            //    PossibleFormats = new List<ZXing.BarcodeFormat>
            //    {
            //        ZXing.BarcodeFormat.EAN_8,
            //        ZXing.BarcodeFormat.EAN_13
            //    }
            //};

            ////add options and customize page
            //scanPage = new ZXingScannerPage(options)
            //{
            //    DefaultOverlayTopText = "Align the barcode within the frame",
            //    DefaultOverlayBottomText = "Scan the Barcode",
            //    DefaultOverlayShowFlashButton = true
            //};

            //scanPage.OnScanResult += (result) =>
            //{
            //    // Stop scanning
            //    scanPage.IsScanning = false;

            //    // Pop the page and show the result
            //    Device.BeginInvokeOnMainThread(async () =>
            //    {
            //        await Navigation.PopAsync();
            //        await DisplayAlert("Scanned Barcode", result.Text, "OK");
            //    });
            //};

            //// Navigate to our scanner page
            //await Navigation.PushAsync(scanPage);


            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    //txtBarcode.Text = result;
                    await DisplayAlert("Scanned Barcode", result, "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Exception",ex.Message.ToString(),"Ok");
            }
        }
    }
}