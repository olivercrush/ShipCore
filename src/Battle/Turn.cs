using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;
using ShipCore.Battle.Actions;

namespace ShipCore.Battle
{
    public class Turn
    {
        private EntityColor _player;
        private List<Actions.Action> _actions;

        public Turn(EntityColor player)
        {
            _player = player;
            _actions = new List<Actions.Action>();
        }

        public EntityColor GetPlayer()
        {
            return _player;
        }
    }
}
