using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleForMoscow.Engine
{
    public enum PhaseType
    {
        Start = 0,

        Replacement = 1,
        Special = 2,
        Combat = 3,
        Movement = 4,

        Housekeeping = 5
    }
}
