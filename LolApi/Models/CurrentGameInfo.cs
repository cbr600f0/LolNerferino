using System.Collections.Generic;

namespace LolApi.Models
{
    public class CurrentGameInfo
    {
        public long GameId { get; set; }
        public long GameLength { get; set; }
        public string GameMode { get; set; }
        public string GameType { get; set; }
        public long GameQueueConfigId { get; set; }
        public long GameStartTime { get; set; }
        public long MapId { get; set; }
        //public Observer Observer { get; set; }
        public string PlatformId { get; set; }
        public List<CurrentGameParticipant> BlueTeamParticipants { get; set; }
        public List<CurrentGameParticipant> RedTeamParticipants { get; set; }
    }
}