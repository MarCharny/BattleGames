using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BattleForMoscow.Common;

namespace BattleForMoscow.Map
{
    public class Cell
    {
        public TerrainType Terrain { get; }

        public Border[] River { get; }

        public Border[] Railroad { get; }

        public Nation StartNation { get; }

        public Point Coordinate { get; }

        public Nation Replacement { get; }

        public CityType City { get; }

        public Nation Controlled { get; }

        public Cell(CellDefinition cell)
        {
            Terrain = cell.Terrain;
            River = cell.River;
            Railroad = cell.Rail;

            StartNation = cell.Start;
            Coordinate = new Point(cell.X, cell.Y);
            Replacement = cell.Replacement;
            City = cell.City;
            Controlled = cell.Control;
        }

    }
}