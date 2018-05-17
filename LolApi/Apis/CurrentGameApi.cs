using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LolApi.Exceptions;
using LolApi.Models;

namespace LolApi.Apis
{
    public static class CurrentGameApi
    {
        public static async Task<CurrentGameInfo> GetSpectatorGameInfoAsync(long summonerId)
        {
            ApiDtos.CurrentGameInfo currentGameInfo;
            try
            {
                currentGameInfo = await ApiCore.HttpGetAsync<ApiDtos.CurrentGameInfo>(
                    $"/observer-mode/rest/consumer/getSpectatorGameInfo/{ApiCore.PlatformId}/{summonerId}");
            }
            catch (HttpRequestException ex)
            {
                throw new NotIngameException();
            }

            return new CurrentGameInfo
            {
                GameId = currentGameInfo.gameId,
                MapId = currentGameInfo.mapId,
                GameMode = currentGameInfo.gameMode,
                GameType = currentGameInfo.gameType,
                GameQueueConfigId = currentGameInfo.gameQueueConfigId,
                GameStartTime = currentGameInfo.gameStartTime,
                GameLength = currentGameInfo.gameLength,
                BlueTeamParticipants = // 100 for blue teamId
                    currentGameInfo.participants.Where(participant => participant.teamId == 100)
                        .Select(participant => new CurrentGameParticipant
                        {
                            TeamId = participant.teamId,
                            Spell1Id = participant.spell1Id,
                            Spell2Id = participant.spell2Id,
                            ChampionId = participant.championId,
                            ProfileIconId = participant.profileIconId,
                            SummonerName = participant.summonerName,
                            Bot = participant.bot,
                            SummonerId = participant.summonerId,
                            Runes = participant.runes.Select(rune => new Rune
                            {
                                Count = rune.count,
                                RuneId = rune.runeId
                            }).ToList(),
                            Masteries = participant.masteries.Select(mastery => new Mastery
                            {
                                Rank = mastery.rank,
                                MasteryId = mastery.masteryId
                            }).ToList()
                        }).ToList(),
                RedTeamParticipants = // 200 for red teamId
                    currentGameInfo.participants.Where(participant => participant.teamId == 200)
                        .Select(participant => new CurrentGameParticipant
                        {
                            TeamId = participant.teamId,
                            Spell1Id = participant.spell1Id,
                            Spell2Id = participant.spell2Id,
                            ChampionId = participant.championId,
                            ProfileIconId = participant.profileIconId,
                            SummonerName = participant.summonerName,
                            Bot = participant.bot,
                            SummonerId = participant.summonerId,
                            Runes = participant.runes.Select(rune => new Rune
                            {
                                Count = rune.count,
                                RuneId = rune.runeId
                            }).ToList(),
                            Masteries = participant.masteries.Select(mastery => new Mastery
                            {
                                Rank = mastery.rank,
                                MasteryId = mastery.masteryId
                            }).ToList()
                        }).ToList()
            };
        }
    }
}