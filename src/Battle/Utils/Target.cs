using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCore.Battle.Utils
{
    public class Target
    {
        Position _pos;

        public Target(Position pos)
        {
            _pos = pos;
        }

        public Position GetPosition() { return _pos; }
    }
}
