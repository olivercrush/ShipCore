using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle.Entity
{
    public class Entity
    {
        private Guid _id;
        public Guid Id => _id;

        private Position _position;
        public Position Position => _position;

        public Entity(Position position)
        {
            _id = Guid.NewGuid();
            _position = position;
        }

        public override String ToString()
        {
            String entityStr = "Entity #" + _id.ToString() + " \n";
            entityStr += "\t Position : " + _position.ToString() + "\n";
            return entityStr;
        }
    }
}
