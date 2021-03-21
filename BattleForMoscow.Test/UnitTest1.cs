using System;
using BattleForMoscow.Engine;
using BattleForMoscow.Map;
using BattleForMoscow.Units;
using Xunit;

namespace BattleForMoscow.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Definitions/Map.json")]
        public void MapTest(string path)
        {
            var map = MapLoader.LoadMap(path);
            Assert.NotEmpty(map.Cells);
        }

        [Theory]
        [InlineData("Definitions/Units.json")]

        public void UnitsTest(string path)
        {
            var units = UnitCreator.LoadUnits(path);
            Assert.NotEmpty(units);
        }

        [Theory]
        [InlineData("Definitions/Turns.json")]

        public void TurnsTest(string path)
        {
            var turns = TurnLoader.Load(path);
            Assert.NotEmpty(turns);
        }
    }
}
