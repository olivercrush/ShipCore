using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;

namespace ShipCore.Battle
{
    public class Turn
    {
        private EntityColor _player;

        public Turn(EntityColor player)
        {
            _player = player;
        }
    }
}
