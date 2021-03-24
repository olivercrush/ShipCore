using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;

namespace ShipCore.Battle.Actions
{
    public abstract class Action
    {
        private Entity _trigger;
        private Entity[] _targets;
        private ActionType _type;

        public Action(Entity trigger, Entity[] targets, ActionType type)
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
