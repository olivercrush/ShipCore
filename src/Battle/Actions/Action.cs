using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle.Actions
{
    public abstract class Action
    {
        private Entity _trigger;
        private Target[] _targets;
        private ActionType _type;

        public Action(Entity trigger, Target[] targets, ActionType type)
        {
            _trigger = trigger;
            _targets = targets;
            _type = type;
        }

        public abstract void ResolveAction();

        public enum ActionType
        {
            MOVEMENT,
            ATTACK,
            SKILL
        }
    }
}
