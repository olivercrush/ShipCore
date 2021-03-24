using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle.Entities
{
    public abstract class Entity
    {
        protected Guid _id;
        public Guid Id => _id;

        protected Position _position;
        public Position Position => _position;

        protected EntityColor _color;
        public EntityColor Color => _color;

        public Entity(Position position, EntityColor color)
        {
            _id = Guid.NewGuid();
            _position = position;
            _color = color;
        }

        public override String ToString()
        {
            String entityStr = "Entity #" + _id.ToString() + " \n";
            entityStr += "\t Position | " + _position.ToString() + "\n";
            entityStr += "\t Color | " + _color.ToString() + "\n";
            return entityStr;
        }
    }

    public enum EntityColor
    {
        BLUE,
        RED,
        WHITE,
        BLACK
    }
}
