using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;
using ShipCore.Battle.Terrains;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle
{
    public class Bridge
    {
        private Battle _battle;

        public Bridge() { _battle = null; }

        public Battle CreateBattle(Entity[] entities, (int, int) dimensions)
        {
            Terrain terrain = new Terrain(dimensions);
            _battle = new Battle(entities, terrain);
            return _battle;
        }

        public void GetUserInput()
        {

        }

        public Battle GetBattle()
        {
            if (_battle == null) throw new Exception("There isn't a battle initialized");
            return _battle;
        }
    }
}
