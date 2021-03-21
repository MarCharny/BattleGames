using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleForMoscow.Engine;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BattleForMoscow.Map
{
    public static class MapLoader
    {
        public static MapEngine LoadMap(string mapDefinition)
        {
            try
            {
                
                var list = JsonConvert.DeserializeObject<List<CellDefinition>>(File.ReadAllText(mapDefinition), new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                });

                var maxX = 0;
                var maxY = 0;
                foreach (var cl in list)
                {
                    if (cl.X > maxX)
                        maxX = cl.X;
                    if (cl.Y > maxY)
                        maxY = cl.Y;
                }

                var cells = new Cell[maxX + 1, maxY + 1];

                foreach (var cl in list)
                {
                    cells[cl.X, cl.Y] = new Cell(cl);
                }

                return new MapEngine(cells);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new MapEngine(new Cell[0,0]);
        }
    }
}
