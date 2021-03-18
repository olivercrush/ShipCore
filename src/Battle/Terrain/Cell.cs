using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ShipCore.Battle.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ShipCore.Battle.Terrain
{
    public class Cell
    {
        public event EventHandler OnHeightChanged;
        
        private Guid _id;
        public Guid Id { get => _id; }
        
        private Position _position;
        public Position Position => _position;

        CellType _type;

        public Cell(Position position) {
            _id = Guid.NewGuid();
            _position = position;
        }

        public JObject ToJsonObject()
        {
            return new JObject(
                new JProperty("id", _id),
                new JProperty("position", _position.ToJsonObject())
            );
        }

        public void SetCellHeight(int height)
        {
            _position = new Position(_position.X, _position.Y, height);
            OnHeightChanged?.Invoke(this, EventArgs.Empty);
        }

        public int GetCellHeight()
        {
            return _position.H;
        }
    }

    struct CellType {
        int id;
        string name;
    }
}