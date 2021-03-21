using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BattleForMoscow.Units
{
    public abstract class UnitCreator
    {
        #region Static realization

        private static Dictionary<UnitType, UnitCreator> creators = new()
        {
            {UnitType.Infantry, new InfantryCreator()},
            {UnitType.Shock, new ShockInfantryCreator()},
            {UnitType.Tank, new TankCreator()}
        };

        #region --

        private static UnitCreator GetCreator(UnitType type)
        {
            return creators[type];
        }

        public static IReadOnlyList<UnitBase> LoadUnits(string definitionFile)
        {
            try
            {
                var result = new List<UnitBase>();
                var unitDefinitions = JsonConvert.DeserializeObject<List<UnitDefinition>>(File.ReadAllText(definitionFile), new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                });

                foreach (var definition in unitDefinitions)
                {
                    result.Add(GetCreator(definition.Type).Create(definition));
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return new List<UnitBase>();
        }

        #endregion

        #endregion

        public abstract UnitBase Create(UnitDefinition definition);
    }

    public class InfantryCreator : UnitCreator
    {
        public override UnitBase Create(UnitDefinition definition)
        {
            return new Infantry(definition);
        }
    }

    public class ShockInfantryCreator : UnitCreator
    {
        public override UnitBase Create(UnitDefinition definition)
        {
            return new ShockInfantry(definition);
        }
    }

    public class TankCreator : UnitCreator
    {
        public override UnitBase Create(UnitDefinition definition)
        {
            return new Tank(definition);
        }
    }
}
