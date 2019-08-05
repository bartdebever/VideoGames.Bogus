using System;
using System.Collections.Generic;
using System.Text;

namespace Bartdebever.Bogus.VideoGames
{
    public interface IVideoGamesDataSet
    {
        /// <summary>
        /// Generates a random Nintendo Switch friend code.
        /// </summary>
        /// <returns>
        /// A random Nintendo Switch Friend Code.
        /// </returns>
        string GenerateSwitchFriendCode();

        /// <summary>
        /// Generates a random PlayStation Network Id.
        /// </summary>
        /// <returns>
        /// Returns a random PlayStation Network Id.
        /// </returns>
        string GeneratePSNId();

        /// <summary>
        /// Generates a random XBox Id.
        /// </summary>
        /// <returns></returns>
        string GenerateXBoxId();

        /// <summary>
        /// Generates a random Super Smash Bros. Ultimate Battle Arena code.
        /// </summary>
        /// <returns>
        /// A random Super Smash Bros. Ultimate Battle Arena code.
        /// </returns>
        string GenerateUltimateArenaCode();

        /// <summary>
        /// Generates a random Super Mario Maker 2 level code using the XXX-XXX-XXX format.
        /// </summary>
        /// <returns>
        /// A random Super Mario Maker 2 level code.
        /// </returns>
        string GenerateMarioMaker2LevelCode();
    }
}
