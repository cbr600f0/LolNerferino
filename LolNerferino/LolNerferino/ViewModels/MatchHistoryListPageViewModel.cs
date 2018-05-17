using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//using LolNerferino.Annotations;
using LolNerferino.Models;

namespace LolNerferino.ViewModels
{
    public class MatchHistoryListPageViewModel : INotifyPropertyChanged
    {
        private List<Match> _matches;

        public List<Match> Matches
        {
            get { return _matches; }
            set
            {
                _matches = value;
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