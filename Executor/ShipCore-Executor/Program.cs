﻿using System;
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
            terrain.SaveTerrain("terrain");
            Console.WriteLine("");*/

            Entity entity = new Entity(new Position(0, 0, 0));
            Console.WriteLine(entity.ToString());
            Console.WriteLine("");

            Characteristics characteristics = new Characteristics(10, 0, 0, 2, 100);
            Character character = new Character(new Position(0, 0, 0), characteristics);
            Console.WriteLine(character.ToString());
            Console.WriteLine("");

            Console.WriteLine("Press key to stop program...");
            Console.ReadKey();
        }
    }
}
