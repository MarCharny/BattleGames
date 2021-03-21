using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BattleForMoscow.Engine
{
    public static class TurnLoader
    {
        public static IReadOnlyList<Turn> Load(string definitionFile)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Turn>>(File.ReadAllText(definitionFile), new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new List<Turn>();
        }
    }
}