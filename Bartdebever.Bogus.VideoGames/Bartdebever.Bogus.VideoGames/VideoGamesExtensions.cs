using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using Bogus.Premium;

namespace Bartdebever.Bogus.VideoGames
{
    /// <summary>
    /// Static class to make the <see cref="Faker"/> have the <see cref="VideoGames"/>
    /// extension method.
    /// </summary>
    public static class VideoGamesExtensions
    {
        /// <summary>
        /// Gets the data set containing different kinds of video game data.
        /// </summary>
        /// <param name="faker">
        /// The faker to be used to generate random data.
        /// </param>
        /// <returns>
        /// An instance of the class inheriting <see cref="IVideoGamesDataSet"/>.
        /// </returns>
        public static IVideoGamesDataSet VideoGames(this Faker faker)
        {
            return ContextHelper.GetOrSet(faker, () => new VideoGameDataSet());
        }
    }
}
