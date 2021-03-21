using System;
using System.Runtime.Serialization;
using BattleForMoscow.Common;
using BattleForMoscow.Map;
using Newtonsoft.Json;

namespace BattleForMoscow.Units
{
    [DataContract]
    public class UnitDefinition
    {
        [JsonProperty]
        public string Number { get; set; }

        [JsonProperty]
        public Nation Nation { get; set; }

        [JsonProperty]
        public UnitType Type { get; set; }

        [JsonProperty]
        public UnitSize Size { get; set; }

        [JsonProperty]
        public int CombatFull { get; set; }

        [JsonProperty]
        public int CombatReduced { get; set; }

        [JsonProperty]
        public int Movement { get; set; }

        [JsonProperty]
        public Strength Strength { get; set; }

        [JsonProperty]
        public Point Position { get; set; }
    }
}