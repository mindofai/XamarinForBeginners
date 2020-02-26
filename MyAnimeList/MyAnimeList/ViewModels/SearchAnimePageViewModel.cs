using MyAnimeList.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAnimeList.ViewModels
{
    public class SearchAnimePageViewModel : ViewModelBase
    {
        public SearchAnimePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ItemTappedCommand = new DelegateCommand<AnimeDetailsModel>(async (item) => await ExecuteItemTappedCommand(item));
        }


        private async Task AcquireData()
        {
            //Add Internet Checking 
            //Add API

            AnimeDetails = new List<AnimeDetailsModel>()
            {
                new AnimeDetailsModel() { Id = 1, Title = "One Piece", Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ", StartDate = "01/01/1990", EndDate = "12/12/2019", ImageSrc = "https://seeklogo.com/images/X/xamarin-logo-348B1EB629-seeklogo.com.png", Rating = 1.0, Website = "https://www.viz.com/one-piece" },
                new AnimeDetailsModel() { Id = 2, Title = "One Piece GOLD", Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ", StartDate = "01/01/1990", EndDate = "12/12/2019", ImageSrc = "https://seeklogo.com/images/X/xamarin-logo-348B1EB629-seeklogo.com.png", Rating = 2.0, Website = "https://www.viz.com/one-piece" },
                new AnimeDetailsModel() { Id = 3, Title = "One Piece SILVER", Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ", StartDate = "01/01/1990", EndDate = "12/12/2019", ImageSrc = "https://seeklogo.com/images/X/xamarin-logo-348B1EB629-seeklogo.com.png", Rating = 3.0, Website = "https://www.viz.com/one-piece" },
                new AnimeDetailsModel() { Id = 3, Title = "One Piece PLATINUM", Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ", StartDate = "01/01/1990", EndDate = "12/12/2019", ImageSrc = "https://seeklogo.com/images/X/xamarin-logo-348B1EB629-seeklogo.com.png", Rating = 4.0, Website = "https://www.viz.com/one-piece" },
                 new AnimeDetailsModel() { Id = 3, Title = "One Piece EMERALD", Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ", StartDate = "01/01/1990", EndDate = "12/12/2019", ImageSrc = "https://seeklogo.com/images/X/xamarin-logo-348B1EB629-seeklogo.com.png", Rating = 5.0, Website = "https://www.viz.com/one-piece" }
            };

            await Task.FromResult(0);
        }

        private List<AnimeDetailsModel> _animeDetails;
        public List<AnimeDetailsModel> AnimeDetails
        {
            get => _animeDetails;
            set => SetProperty(ref _animeDetails, value);
        }

        public DelegateCommand<AnimeDetailsModel> ItemTappedCommand { get; private set; }

        private async Task ExecuteItemTappedCommand(AnimeDetailsModel item)
        {
            var navParameters = new NavigationParameters();
            navParameters.Add("SelectedAnime", item);

            await NavigationService.NavigateAsync("AnimeDetailsPage", navParameters);
        }

        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (AnimeDetails == null)
            {
                await AcquireData();
            }
        }
    }
}
