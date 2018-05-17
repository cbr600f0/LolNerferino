using System;
using LolNerferino.ViewModels;
using Xamarin.Forms;

namespace LolNerferino
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainPageViewModel();
            BindingContext = _viewModel;
        }

        public void SendRequest()
        {
        }

        private async void CurrentGameButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CurrentGameInfoPage(_viewModel.SummonerName));
        }

        private async void MatchHistoryButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchHistoryListPage());
        }
    }
}