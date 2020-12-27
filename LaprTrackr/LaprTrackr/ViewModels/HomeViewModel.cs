using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Mobile;

namespace LaprTrackr.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public Command ScanCommand { get; set; }

        public HomeViewModel()
        {
            Title = "Dashboard";
            ScanCommand = new Command(async () =>
            {
                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan();

                if (result != null) await Application.Current.MainPage.DisplayAlert("Scanned", result.Text, "CANCEL");
            });
        }
    }
}
