using System;
using Bogus;

namespace Bartdebever.Bogus.VideoGames.Tests
{
    public class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();
            var videoGames = faker.VideoGames();

            Console.WriteLine("Switch FriendCodes");
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(videoGames.GenerateSwitchFriendCode());
            }

            Console.WriteLine("Smash Arenas");
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(videoGames.GenerateUltimateArenaCode());
            }

            Console.WriteLine("Mario Maker Levels");
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(videoGames.GenerateMarioMaker2LevelCode());
            }

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
