using System.ComponentModel;
using System.Runtime.CompilerServices;
//using LolNerferino.Annotations;

namespace LolNerferino.ViewModels
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private string _summonerName;

        public string SummonerName
        {
            get { return _summonerName; }
            set
            {
                _summonerName = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}