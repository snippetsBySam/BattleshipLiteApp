﻿using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary
{
    public static class GameLogic
    {
        public static int GetShotCount(PlayerInfoModel player)
        {
            int shotCount = 0;

            foreach (var shot in player.ShotGrid)
            {
                if (shot.Status == GridSpotStatus.Miss || shot.Status == GridSpotStatus.Hit)
                {
                    shotCount++;
                }
            }
            return shotCount;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            throw new NotImplementedException();
        }

        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }
            }
        }

        public static void MarkShotResult(PlayerInfoModel activePlayer, string row, int column, bool isAHit)
        {
            throw new NotImplementedException();
        }

        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
            throw new NotImplementedException();
        }

        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            bool isActive = false;

            foreach (var ship in player.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    isActive = true;
                    break;
                }
            }
            return isActive;
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            throw new NotImplementedException();
        }

        public static bool ValidateShot(PlayerInfoModel activePlayer, string row, int column)
        {
            throw new NotImplementedException();
        }

        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);
        }
    }
}
