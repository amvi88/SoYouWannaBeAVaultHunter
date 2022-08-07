using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using Site.Models;

namespace Site.Services
{
    public interface ICardEntriesService
    {
        Task<CardEntry[]> GetCardEntries();
    }

    public class CardEntriesService : ICardEntriesService
    {
        private readonly HttpClient HttpClient;
        public async Task<CardEntry[]> GetCardEntries()
        {
            return await HttpClient.GetFromJsonAsync<CardEntry[]>("data/cardentries.json") ?? new CardEntry[0];
        }
    }

}