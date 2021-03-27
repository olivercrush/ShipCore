using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Entities;
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
            terrain.SaveTerrain("terrain");
            Console.WriteLine("");*/

            /*Entity entity = new Entity(new Position(0, 0, 0), EntityColor.WHITE);
            Console.WriteLine(entity.ToString());
            Console.WriteLine("");*/

            Characteristics characteristics = new Characteristics(10, 2, 100, 2, 5);
            Character character = new Character(new Position(0, 0, 0), EntityColor.BLUE, characteristics);
            Console.WriteLine(character.ToString());
            Console.WriteLine("");

            ActionStringInterpreter.IsStringValid(character.Id.ToString() + ":ACTION:(0,0):PARAM1:PARAM2");

            Console.WriteLine("Press key to stop program...");
            Console.ReadKey();
        }
    }
}
