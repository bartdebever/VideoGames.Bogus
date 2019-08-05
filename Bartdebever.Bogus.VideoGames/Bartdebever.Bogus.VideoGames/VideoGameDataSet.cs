using System;
using System.Collections.Generic;
using System.Text;
using Bogus;

namespace Bartdebever.Bogus.VideoGames
{
    public class VideoGameDataSet : DataSet, IVideoGamesDataSet
    {
        public string GenerateSwitchFriendCode()
        {
            const string legalCharacters = "013456789";

            return $"SW-{Random.String2(4, legalCharacters)}-{Random.String2(4, legalCharacters)}-{Random.String2(4, legalCharacters)}";
        }

        public string GeneratePSNId()
        {
            throw new NotImplementedException();
        }

        public string GenerateXBoxId()
        {
            throw new NotImplementedException();
        }

        public string GenerateUltimateArenaCode()
        {
            return Random.AlphaNumeric(5).ToUpper();
        }

        public string GenerateMarioMaker2LevelCode()
        {
            return $"{Random.AlphaNumeric(3)}-{Random.AlphaNumeric(3)}-{Random.AlphaNumeric(3)}".ToUpper();
        }
    }
}
