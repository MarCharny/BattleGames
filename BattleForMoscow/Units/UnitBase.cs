using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;
using BattleForMoscow.Common;
using BattleForMoscow.Map;
using Newtonsoft.Json.Linq;

namespace BattleForMoscow.Units
{
    public abstract class UnitBase
    {
        protected readonly int combatFull;
        protected readonly int combatReduced;
        protected readonly int movement;


        public string UnitNumber { get; }
        public Nation Nation { get; }

        public UnitSize Size { get; }

        public Point InitialPosition { get; }

        public Strength Strength { get; }


        public int Combat
        {
            get
            {
                return Strength == Strength.Full ? combatFull : combatReduced;
            }
        }

        //public int Movement { get; }

        protected UnitBase(UnitDefinition definition)
        {
            UnitNumber = definition.Number;

            Nation = definition.Nation;
            Size = definition.Size;
            InitialPosition = definition.Position;
            combatFull = definition.CombatFull;
            combatReduced = definition.CombatReduced;
            movement = definition.Movement;
            Strength = definition.Strength;
        }
    }
}