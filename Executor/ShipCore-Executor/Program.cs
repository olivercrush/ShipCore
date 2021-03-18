using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Terrain;
using ShipCore.Battle.Entity;
using ShipCore.Battle.Utils;

namespace ShipCore_Executor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Terrain terrain = new Terrain((10, 10));
            terrain.UpdateCell((5, 5), 3, HeightUpdateMethod.SET);
            Console.WriteLine(terrain.ToString());
            terrain.SaveTerrain("terrain");*/

            Entity entity = new Entity(new Position(0, 0, 0));
            Console.WriteLine(entity.ToString());

            Console.WriteLine("Press key to stop program...");
            Console.ReadKey();
        }
    }
}
