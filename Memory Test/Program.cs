using System;
using System.Collections.Generic;

namespace Memory_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating guild info");
            List<ulong> whitelistedChannels = new List<ulong>();

            for (int x = 0; x < 5; x++)
            {
                whitelistedChannels.Add(ulong.MaxValue);
            }

            int count = 100000;
            Console.WriteLine($"Copying data for {count} guilds");

            Dictionary<ulong, GuildConfig> guildConfigs = new Dictionary<ulong, GuildConfig>();
            for (int i = 0; i < count; i++)
            {
                guildConfigs.Add(ulong.MaxValue - (ulong)i, new GuildConfig()
                {
                    guildId = ulong.MaxValue,
                    prefix = new string(i.ToString().ToCharArray()[0], 10),
                    whitelistedChannels = whitelistedChannels,
                    isLooping = true,
                    volume = 150
                });
            }
            Console.WriteLine("DONE :O");
            Console.ReadLine();
        }
    }

    public class GuildConfig
    {
        public ulong guildId { get; set; }
        public string prefix { get; set; }
        public List<ulong> whitelistedChannels { get; set; }
        public bool isLooping { get; set; }
        public int volume { get; set; }
    }
}
