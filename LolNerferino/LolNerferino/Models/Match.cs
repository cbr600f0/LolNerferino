using System;
//using SQLite;

namespace LolNerferino.Models
{
    public class Match
    {
        //[AutoIncrement]
        //[PrimaryKey]
        public int Id { get; set; }

        public string Cs { get; set; }
        public TimeSpan Time { get; set; }
        public string KDA { get; set; }
        public string Ratio { get; set; }
        public string Map { get; set; }
        public string GameMode { get; set; }
        public string ResultColor { get; set; }
    }
}