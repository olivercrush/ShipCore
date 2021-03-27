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
        private List<Entity> _entities;
        private Terrain _terrain;

        private List<Turn> _turns;
        private bool _redFirst;

        public Battle(Entity[] entities)
        {
            _entities = new List<Entity>();
            _entities.AddRange(entities);

            _terrain = new Terrain((20, 20));
            InitialiseBattle();
        }

        public Battle(Entity[] entities, Terrain terrain)
        {
            _entities = new List<Entity>();
            _entities.AddRange(entities);

            _terrain = terrain;
            InitialiseBattle();
        }

        private void InitialiseBattle()
        {
            _redFirst = (new Random().Next(0, 2)) >= 1;
            CreateTurn((_redFirst) ? EntityColor.RED : EntityColor.BLUE);
        }

        private void CreateTurn(EntityColor player)
        {
            Turn turn = new Turn(player);
            _turns.Add(turn);
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
