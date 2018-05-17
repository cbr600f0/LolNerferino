using System.Collections.Generic;

namespace LolApi.ApiDtos
{
    public class CurrentGameParticipant
    {
        public bool bot { get; set; }
        public long championId { get; set; }
        public long profileIconId { get; set; }
        public long spell1Id { get; set; }
        public long spell2Id { get; set; }
        public long summonerId { get; set; }
        public string summonerName { get; set; }
        public long teamId { get; set; }
        public List<Mastery> masteries { get; set; }
        public List<Rune> runes { get; set; }
    }
}