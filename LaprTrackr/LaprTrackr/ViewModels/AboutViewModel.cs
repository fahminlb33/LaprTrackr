using LaprTrackr.Views;
using Plugin.FirebaseAnalytics;
using Plugin.GoogleClient;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing.Mobile;

namespace LaprTrackr.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {


            Title = "About";
            OpenWebCommand = new Command(async () =>
            {
                CrossFirebaseAnalytics.Current.LogEvent(EventName.SelectContent,
                                        new Parameter(ParameterName.ItemId, "about"),
                                        new Parameter(ParameterName.ItemName, "about button"));

                var parameters = new Dictionary<string, object>
                {
                    [ParameterName.ItemId] = 1,
                    [ParameterName.ItemName] = "test"
                };
                CrossFirebaseAnalytics.Current.LogEvent(EventName.SelectContent, parameters);
            });


        }




        public ICommand OpenWebCommand { get; }
    }
}