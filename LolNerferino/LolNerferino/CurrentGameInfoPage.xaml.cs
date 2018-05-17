using System;
using System.Linq;
using LolApi.Apis;
using LolApi.Exceptions;
using LolApi.Models;
using LolNerferino.ViewModels;
using Xamarin.Forms;

namespace LolNerferino
{
    public partial class CurrentGameInfoPage : ContentPage
    {
        private readonly CurrentGameInfoPageViewModel _viewModel;

        public CurrentGameInfoPage(string summonerName)
        {
            InitializeComponent();
            _viewModel = new CurrentGameInfoPageViewModel { SummonerName = summonerName };
            BindingContext = _viewModel;
        }

        private async void CurrentGameInfoPage_OnAppearing(object sender, EventArgs e)
        {
            var summoners = await SummonerApi.GetSummonersByNamesAsync(_viewModel.SummonerName);
            var summoner = summoners.First();
            CurrentGameInfo currentGameInfo;
            try
            {
                currentGameInfo = await CurrentGameApi.GetSpectatorGameInfoAsync(summoner.Id);
            }
            catch (NotIngameException)
            {
                await DisplayAlert("Not in game", "This summoner is not ingame", "OK");
                await Navigation.PopAsync(true);
                return;
            }
            _viewModel.CurrentGameInfo = currentGameInfo;
        }
    }
}