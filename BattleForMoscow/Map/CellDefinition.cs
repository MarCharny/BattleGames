using System.Runtime.Serialization;
using BattleForMoscow.Common;
using Newtonsoft.Json;

namespace BattleForMoscow.Map
{
    [DataContract]
    public class CellDefinition
    {
        [JsonProperty]
        public int X { get; set; }

        [JsonProperty]
        public int Y { get; set; }

        [JsonProperty]
        public TerrainType Terrain { get; set; }

        [JsonProperty]
        public Nation Replacement { get; set; }

        [JsonProperty]
        public Border[] Rail { get; set; }

        [JsonProperty]
        public Border[] River { get; set; }

        [JsonProperty]
        public Nation Start { get; set; }

        [JsonProperty]
        public CityType City { get; set; }

        [JsonProperty]
        public Nation Control { get; set; }
    }
}