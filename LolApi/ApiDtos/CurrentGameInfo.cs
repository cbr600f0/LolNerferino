using System.Collections.Generic;

namespace LolApi.ApiDtos
{
    public class CurrentGameInfo
    {
        public long gameId { get; set; }
        public long gameLength { get; set; }
        public string gameMode { get; set; }
        public string gameType { get; set; }
        public long gameQueueConfigId { get; set; }
        public long gameStartTime { get; set; }
        public long mapId { get; set; }
        //public Observer Observer { get; set; }
        public string platformId { get; set; }
        public List<CurrentGameParticipant> participants { get; set; }
    }
}