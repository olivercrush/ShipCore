using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCore.Battle.Entity
{
    public class CharacteristicsContainer
    {
        private Characteristics _base;
        private int _health;
        private int _mobility;
        private int _initiative;

        public CharacteristicsContainer(Characteristics characteristics)
        {
            _base = characteristics;
            _health = characteristics.Health;
            _mobility = characteristics.Mobility;
            _initiative = characteristics.Initiative;
        }

        public Characteristics GetCharacteristics()
        {
            return new Characteristics(_health, _mobility, _initiative);
        }

        public Characteristics GetBaseCharacteristics()
        {
            return _base;
        }

        public void UpdateHealth(UpdateMethod updateMethod, int value) { _health = (updateMethod == UpdateMethod.SET) ? value : _health + value ; }
        public void UpdateMobility(UpdateMethod updateMethod, int value) { _mobility = (updateMethod == UpdateMethod.SET) ? value : _mobility + value ; }
        public void UpdateInitiative(UpdateMethod updateMethod, int value) { _initiative = (updateMethod == UpdateMethod.SET) ? value : _initiative + value ; }
    }

    public enum UpdateMethod
    {
        SET,
        ADD
    }

    public readonly struct Characteristics
    {
        public int Health { get; }
        public int Mobility { get; }
        public int Initiative { get; }

        public Characteristics(int health, int mobility, int initiative)
        {
            Health = health;
            Mobility = mobility;
            Initiative = initiative;
        }

        public override String ToString()
        {
            return ("health : " + Health + ", mobility : " + Mobility + ", initiative : " + Initiative);
        }
    }
}
