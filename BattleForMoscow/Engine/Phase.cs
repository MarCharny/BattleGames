using BattleForMoscow.Common;
using Newtonsoft.Json;

namespace BattleForMoscow.Engine
{
    public class Phase
    {
        [JsonProperty]
        public PhaseType Type { get; private set; }

        [JsonProperty]
        public Nation Nation { get; private set; }

        [JsonProperty]
        public int Amount { get; private set; }
    }
}