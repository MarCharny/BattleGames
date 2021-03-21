using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using BattleForMoscow.Map;
using BattleForMoscow.Units;

namespace BattleForMoscow.Engine
{
    public class GameEngine
    {
        public static GameEngine Default { get;} = new ();


        private const string turnsDefinitionFile = "Definitions/Turns.json";
        private const string mapDefinitionFile = "Definitions/Map.json";
        private const string unitsDefinitionFile = "Definitions/Units.json";
        private MapEngine Map { get; }

        private IReadOnlyList<Turn> Turns { get; }
        private IReadOnlyList<UnitBase> Units { get; }

        

        private GameEngine()
        {
            var rootCatalog = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Turns = TurnLoader.Load(Path.Combine(rootCatalog, turnsDefinitionFile));
            Units = UnitCreator.LoadUnits(Path.Combine(rootCatalog, unitsDefinitionFile));
            Map = MapLoader.LoadMap(Path.Combine(rootCatalog, mapDefinitionFile));
        }
        
    }
}