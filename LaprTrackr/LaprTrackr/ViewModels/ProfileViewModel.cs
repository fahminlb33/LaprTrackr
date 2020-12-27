using LaprTrackr.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LaprTrackr.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public Command AboutCommand { get; }

        public ProfileViewModel()
        {
            AboutCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(AboutPage)}"));
            LoginCommand = new Command(async () =>
            {
         
            });
        }

        public ICommand LoginCommand { get; set; }
    }
}
