using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ShipCore.Battle.Utils
{
    public readonly struct Position
    {
        public int X { get; }
        public int Y { get; }
        public int H { get; }

        public Position(int x, int y, int h)
        {
            X = x;
            Y = y;
            H = h;
        }

        public JObject ToJsonObject()
        {
            return new JObject(
                new JProperty("x", X),
                new JProperty("y", Y),
                new JProperty("h", H)
            );
        }

        public override String ToString()
        {
            return ("x : " + X + ", y : " + Y + ", h : " + H);
        }
    }
}
