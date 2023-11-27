using System.Net.Http.Headers;
using System.Text.Json;

namespace WebApiClient
{
    class Program
    {
        public static async Task Main()
        {
            LiveChannelInformation analytics = new LiveChannelInformation();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Stat-Milestones Live Channels v1.0");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Querying API");
            Console.WriteLine("----------------------------------------");
            var liveChannelsResponse = await analytics.GetLiveChannelsAsync();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Total Live Broadcasters:{liveChannelsResponse.total}");
            Console.WriteLine("----------------------------------------");


            var darkModeOnly = liveChannelsResponse.channels.Where(i => i.configuration.panel_settings.dark_mode == true).ToList();
            Console.WriteLine($"Broadcasters with DarkMode Enabled: {darkModeOnly.Count}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("GAMES");
            Console.WriteLine("----------------------------------------");
            var gameNamesByBroadcasters = liveChannelsResponse.channels.GroupBy(e => e.game_name).ToDictionary(k => k.Key, x => x.ToList().Count);
            gameNamesByBroadcasters.OrderByDescending(pair => pair.Value).Select(i => $"| {i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("END");
            Console.WriteLine("----------------------------------------");
        }
    }

    class LiveChannelInformation {
        private HttpClient client;

        public LiveChannelInformation() {
            client = new();
        }

        public async Task<LiveChannelsResponse> GetLiveChannelsAsync()
        {
            await using Stream stream =
                await client.GetStreamAsync("https://api.stat-milestones.dev/live-channels");
            var channelsResponse =
                await JsonSerializer.DeserializeAsync<LiveChannelsResponse>(stream);

            return channelsResponse ?? new();
        }
    }
}
