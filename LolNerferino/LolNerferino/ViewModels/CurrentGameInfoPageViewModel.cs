using System.ComponentModel;
using System.Runtime.CompilerServices;
using LolApi.Models;
using LolNerferino.Annotations;

namespace LolNerferino.ViewModels
{
    public class CurrentGameInfoPageViewModel : INotifyPropertyChanged
    {
        private CurrentGameInfo _currentGameInfo;
        public string SummonerName { get; set; }

        public CurrentGameInfo CurrentGameInfo
        {
            get { return _currentGameInfo; }

            set
            {
                _currentGameInfo = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}