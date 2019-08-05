using System;
using System.Collections.Generic;
using System.Text;
using Bogus;

namespace Bartdebever.Bogus.VideoGames
{
    public class VideoGameDataSet : DataSet, IVideoGamesDataSet
    {
        /// <summary>
        /// Generates a random Nintendo Switch friend code.
        /// </summary>
        /// <returns>
        /// A random Nintendo Switch Friend Code.
        /// </returns>
        public string GenerateSwitchFriendCode()
        {
            const string legalCharacters = "013456789";

            return $"SW-{Random.String2(4, legalCharacters)}-{Random.String2(4, legalCharacters)}-{Random.String2(4, legalCharacters)}";
        }

        /// <summary>
        /// Generates a random PlayStation Network Id.
        /// </summary>
        /// <returns>
        /// Returns a random PlayStation Network Id.
        /// </returns>
        public string GeneratePSNId()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a random XBox Id.
        /// </summary>
        /// <returns></returns>
        public string GenerateXBoxId()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a random Super Smash Bros. Ultimate Battle Arena code.
        /// </summary>
        /// <returns>
        /// A random Super Smash Bros. Ultimate Battle Arena code.
        /// </returns>
        public string GenerateUltimateArenaCode()
        {
            return Random.AlphaNumeric(5).ToUpper();
        }

        /// <summary>
        /// Generates a random Super Mario Maker 2 level code using the XXX-XXX-XXX format.
        /// </summary>
        /// <returns>
        /// A random Super Mario Maker 2 level code.
        /// </returns>
        public string GenerateMarioMaker2LevelCode()
        {
            return $"{Random.AlphaNumeric(3)}-{Random.AlphaNumeric(3)}-{Random.AlphaNumeric(3)}".ToUpper();
        }
    }
}
