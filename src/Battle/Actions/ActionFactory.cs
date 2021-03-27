using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle.Actions
{
    public static class ActionFactory
    {
        public static Movement CreateMoveAction(Entity trigger, Target target)
        {
            return new Movement(trigger, new Target[] { target });
        }
    }
}
