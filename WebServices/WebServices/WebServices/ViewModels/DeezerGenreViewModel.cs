using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WebServices.Models;
using WebServices.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WebServices.ViewModels
{
	public class DeezerGenreViewModel
	{
		public string Id { get; set; }
        public Command GetGenreCommand { get; set; }
        IApiServices apiServices = new ApiServices();

        public event PropertyChangedEventHandler PropertyChanged;

        public Genre GetGenre { get; set; } = new Genre();
        public DeezerGenreViewModel()
        {
            var current = Connectivity.NetworkAccess;
            GetGenreCommand = new Command(async() =>
            {
                if ((current == NetworkAccess.Internet) && !string.IsNullOrEmpty(Id))
                {
                    await GetGenreAsync();
                } else if (((current != NetworkAccess.Internet) && !string.IsNullOrEmpty(Id)) || ((current != NetworkAccess.Internet) && string.IsNullOrEmpty(Id)))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "No internet available.", "OK");
                } else if ((current == NetworkAccess.Internet) && string.IsNullOrEmpty(Id))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Field is empty. Please try again.", "OK");
                }
            });
        }

        public async Task GetGenreAsync()
        {
            GetGenre = await apiServices.GetGenre(Id);
        }
	}
}
