using System.Collections.Generic;

namespace LolApi.Models
{
    public class CurrentGameParticipant
    {
        public bool Bot { get; set; }
        public long ChampionId { get; set; }
        public long ProfileIconId { get; set; }
        public long Spell1Id { get; set; }
        public long Spell2Id { get; set; }
        public long SummonerId { get; set; }
        public string SummonerName { get; set; }
        public long TeamId { get; set; }
        public List<Mastery> Masteries { get; set; }
        public List<Rune> Runes { get; set; }
        
    }
}