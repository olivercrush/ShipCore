using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;

namespace ShipCore.Battle.Actions
{
    public class Movement : Action
    {
        public Movement(Entity trigger, Entity[] targets) : base(trigger, targets, ActionType.MOVEMENT) 
        { 

        }

        public override void ResolveAction()
        {
            throw new NotImplementedException();
        }
    }
}
