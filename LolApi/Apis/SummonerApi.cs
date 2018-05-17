using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LolApi.Models;

namespace LolApi.Apis
{
    public static class SummonerApi
    {
        public static async Task<IEnumerable<Summoner>> GetSummonersByNamesAsync(params string[] names)
        {
            if (names.Length > 40)
                throw new ArgumentOutOfRangeException(nameof(names), "There is a limit of maximum 40 names!");

            var encodedNames = names.Select(name => name.Replace(" ", "").ToLower()).ToList();
            var namesString = string.Join(",", encodedNames);
            var data =
                await ApiCore.HttpGetAsync<dynamic>($"/api/lol/{ApiCore.Region}/v1.4/summoner/by-name/{namesString}");

            return encodedNames.Select(name =>
            {
                var summonerData = data[name];
                return new Summoner
                {
                    Id = (long) summonerData["id"],
                    Name = (string) summonerData["name"],
                    ProfileIconId = (int) summonerData["profileIconId"],
                    SummonerLevel = (long) summonerData["summonerLevel"]
                };
            }).ToList();
        }
    }
}