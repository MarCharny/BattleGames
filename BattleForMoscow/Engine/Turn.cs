using System.Collections.Generic;
using BattleForMoscow.Common;
using Newtonsoft.Json;

namespace BattleForMoscow.Engine
{
    public class Turn
    {
        [JsonProperty]
        public int Number { get; private set; }

        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public WeatherCondition Weather { get; private set; }

        [JsonProperty]
        public IReadOnlyList<Phase> Phases { get; private set;}
    }
}