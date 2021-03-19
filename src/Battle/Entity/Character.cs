﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCore.Battle.Utils;

namespace ShipCore.Battle.Entity
{
    public class Character : Entity
    {
        public CharacteristicsContainer CharacteristicsContainer;

        public Character(Position position, Characteristics characteristics) : base(position)
        {
            CharacteristicsContainer = new CharacteristicsContainer(characteristics);
        }

        public override String ToString()
        {
            String characterStr = "Entity (Character) #" + _id.ToString() + " \n";
            characterStr += "\t Position | " + _position.ToString() + "\n";
            characterStr += "\t Characteristics | " + CharacteristicsContainer.GetCharacteristics().ToString() + "\n";
            return characterStr;
        }
    }
}