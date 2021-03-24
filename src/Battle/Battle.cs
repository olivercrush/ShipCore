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

        private bool _isOver;
        private EntityColor _turnPlayer;
        private EntityColor _actionPlayer;

        public Battle(Entity[] entities)
        {
            _entities = entities;
            _terrain = new Terrain((20, 20));
            _isOver = false;
        }

        public Battle(Entity[] entities, Terrain terrain)
        {
            _entities = entities;
            _terrain = terrain;
        }

        public void RunBattle()
        {
            while (!_isOver)
            {
                // game loop
            }
        }
    }
}
