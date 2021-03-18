using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle.Terrain
{
    // TODO#3: Load terrain from json file 
    
    public class Terrain {

        private Guid _id;
        public Guid Id => _id;

        private Cell[,] _cells;
        public Cell[,] Cells => _cells;

        public Terrain((int w, int h) dimensions) {
            _id = Guid.NewGuid();
            GenerateTerrain(dimensions);
        }

        public Terrain(String name) {
            // [3]
        }

        public void SaveTerrain(String name)
        {
            JObject[] jsonCells = new JObject[_cells.Length];
            for (int y = 0; y < _cells.GetLength(1); y++) {
                for (int x = 0; x < _cells.GetLength(0); x++)
                {
                    jsonCells[y * _cells.GetLength(0) + x] = _cells[x, y].ToJsonObject();
                }
            }

            // DOC : https://www.newtonsoft.com/json/help/html/WriteToJsonFile.htm
            JObject jsonTerrain = new JObject(
                new JProperty("name", name),
                new JProperty("id", _id.ToString()),
                new JProperty("cells", jsonCells)
            );
            
            File.WriteAllText("terrains/" + name + ".json", jsonTerrain.ToString());
            Console.Write(name + ".json saved in terrains directory \n");
        }

        private void GenerateTerrain((int w, int h) dimensions) {
            _cells = new Cell[dimensions.w, dimensions.h];
            for (int y = 0; y < dimensions.h; y++) {
                for (int x = 0; x < dimensions.w; x++) {
                    _cells[x, y] = new Cell(new Position(x, y, 0));
                }
            }
        }

        public void UpdateCell(Guid id, int height, HeightUpdateMethod updateMethod) {
            for (int y = 0; y < _cells.GetLength(1); y++)
            {
                for (int x = 0; x < _cells.GetLength(0); x++)
                {
                    if (_cells[x, y].Id == id)
                        UpdateCell((x, y), height, updateMethod);
                }
            }
        }
        
        public void UpdateCell((int x, int y) coordinates, int height, HeightUpdateMethod updateMethod) {
            if (updateMethod == HeightUpdateMethod.SET)
            {
                _cells[coordinates.x, coordinates.y].SetCellHeight(height);

            }
            else if (updateMethod == HeightUpdateMethod.ADD)
            {
                _cells[coordinates.x, coordinates.y].SetCellHeight(_cells[coordinates.x, coordinates.y].GetCellHeight() + height);
            }
        }

        public override String ToString() {
            String terrainStr = "Terrain #" + _id.ToString() + "\n";
            for (int y = 0; y < _cells.GetLength(1); y++) {
                terrainStr += "\t";
                for (int x = 0; x < _cells.GetLength(0); x++) {
                    terrainStr += _cells[x,y].GetCellHeight() + " ";
                }
                terrainStr += "\n";
            }
            return terrainStr;
        }
    }

    public enum HeightUpdateMethod
    {
        SET,
        ADD
    }
}