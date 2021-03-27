using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCore.Battle.Entities
{
    public class CharacteristicsContainer
    {
        private Characteristics _base;
        private int _health;
        private int _mobility;
        private int _initiative;
        
        private int _attack;
        private int _range;

        public CharacteristicsContainer(Characteristics characteristics)
        {
            _base = characteristics;
            _health = characteristics.Health;
            _mobility = characteristics.Mobility;
            _initiative = characteristics.Initiative;
            _attack = characteristics.Attack;
            _range = characteristics.Range;
        }

        public Characteristics GetCharacteristics()
        {
            return new Characteristics(_health, _mobility, _initiative, _attack, _range);
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
        public int Attack { get; }
        public int Range { get; }

        public Characteristics(int health, int mobility, int initiative, int attack, int range)
        {
            Health = health;
            Mobility = mobility;
            Initiative = initiative;
            Attack = attack;
            Range = range;
        }

        public override String ToString()
        {
            return ("health : " + Health + ", mobility : " + Mobility + ", initiative : " + Initiative + ", attack : " + Attack + ", range : " + Range);
        }
    }
}
