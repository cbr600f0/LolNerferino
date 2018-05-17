using System;

namespace LolApi.Models
{
    public class Summoner
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public DateTime RevisionDate { get; set; }
        public long SummonerLevel { get; set; }
    }
}