using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;
using ShipCore.Battle.Terrains;

namespace ShipCore.Battle
{
    public class Battle
    {
        private Entity[] _entities;
        private Terrain _terrain;


        public Battle(Entity[] entities)
        {
            _entities = entities;
            _terrain = new Terrain((20, 20));
        }

        public Battle(Entity[] entities, Terrain terrain)
        {
            _entities = entities;
            _terrain = terrain;
        }


        public bool CheckGameOver()
        {
            int countRed = 0;
            int countBlue = 0;

            foreach (Entity e in _entities)
            {
                countRed += (e.Color == EntityColor.RED) ? 1 : 0;
                countBlue += (e.Color == EntityColor.BLUE) ? 1 : 0;
            }

            return (countRed == 0) || (countBlue == 0);
        }
    }
}
