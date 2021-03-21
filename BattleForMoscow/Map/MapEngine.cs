using System.Collections.Generic;

namespace BattleForMoscow.Map
{
    public class MapEngine
    {
        private Cell[,] Cells { get; }

        public MapEngine(Cell[,] cells)
        {
            Cells = cells;
        }
    }
}