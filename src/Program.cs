using ShipCore.Battle.Terrain;
using ShipCore.Battle.Entity;

namespace ShipCore
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Terrain terrain = new Terrain((10, 10));
            terrain.UpdateCell((5, 5), 3, HeightUpdateMethod.SET);
            terrain.ToString();
            terrain.SaveTerrain("terrain");
        }
    }
}