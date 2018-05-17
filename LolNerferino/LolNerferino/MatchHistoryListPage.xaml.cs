using System;
using LolNerferino.Models;
using LolNerferino.ViewModels;
using Xamarin.Forms;

namespace LolNerferino
{
    public partial class MatchHistoryListPage : ContentPage
    {
        private readonly MatchHistoryListPageViewModel _viewModel;
        public int Assists = 12;
        public int Deaths = 2;
        public int Kills = 5;
        public int RatioCalculation;
        public string ResultColor;
        public bool Win;

        public MatchHistoryListPage()
        {
            InitializeComponent();
            RatioCalculation = (Kills + Assists) / Deaths;
            _viewModel = new MatchHistoryListPageViewModel();
            BindingContext = _viewModel;
        }

        private void ListView_OnSizeChanged(object sender, EventArgs e)
        {
            ListView.RowHeight = (int)ListView.Height / 5;
        }

        private async void MatchHistoryListPage_OnAppearing(object sender, EventArgs e)
        {
            //var conn = await Database.GetConnectionAsync();
            //_viewModel.Matches = await conn.Table<Match>().ToListAsync();
            //_viewModel.Matches.Reverse();
        }
    }
}