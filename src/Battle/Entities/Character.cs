using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle.Entities
{
    public class Character : Entity
    {
        public CharacteristicsContainer CharacteristicsContainer;

        public Character(Position position, EntityColor color, Characteristics characteristics) : base(position, color)
        {
            CharacteristicsContainer = new CharacteristicsContainer(characteristics);
        }

        public override String ToString()
        {
            String characterStr = "Entity (Character) #" + _id.ToString() + " \n";
            characterStr += "\t Position | " + _position.ToString() + "\n";
            characterStr += "\t Color | " + _color.ToString() + "\n";
            characterStr += "\t Characteristics | " + CharacteristicsContainer.GetCharacteristics().ToString() + "\n";
            return characterStr;
        }
    }
}
