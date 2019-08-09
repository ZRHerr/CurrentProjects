using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class Enums
    {
        public enum GameState
        {
            StartMenu,
            NewGame,
            LoadGame,
            HighScores,
            Playing,
            Defeat,
            Victory,
            Exit
        }

        public enum MenuChoice
        {
            NewGame,
            LoadGame,
            HighScores,
            Exit,
            Invalid
        }
        public enum PlayerClass
        {
            Traveller,
            Merchant,
            Hauler,
            NoClass
        }
        public enum MerchantAction
        {
            Buy = 1,
            Sell = 2,
            Exit = 3
        }

    }
}

