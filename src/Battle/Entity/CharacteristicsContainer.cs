using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCore.Battle.Entity
{
    public class CharacteristicsContainer
    {
        private int _health;
        private int _pArmor;
        private int _mArmor;
        private int _mobility;
        private int _initiative;

        public CharacteristicsContainer(Characteristics characteristics)
        {
            _health = characteristics.Health;
            _pArmor = characteristics.PArmor;
            _mArmor = characteristics.MArmor;
            _mobility = characteristics.Mobility;
            _initiative = characteristics.Initiative;
        }

        public Characteristics GetCharacteristics()
        {
            return new Characteristics(_health, _pArmor, _mArmor, _mobility, _initiative);
        }

        public void UpdateHealth(UpdateMethod updateMethod, int value) { _health = (updateMethod == UpdateMethod.SET) ? value : _health + value ; }
        public void UpdatePArmor(UpdateMethod updateMethod, int value) { _pArmor = (updateMethod == UpdateMethod.SET) ? value : _pArmor + value ; }
        public void UpdateMArmor(UpdateMethod updateMethod, int value) { _mArmor = (updateMethod == UpdateMethod.SET) ? value : _mArmor + value ; }
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
        public int PArmor { get; }
        public int MArmor { get; }
        public int Mobility { get; }
        public int Initiative { get; }

        public Characteristics(int health, int pArmor, int mArmor, int mobility, int initiative)
        {
            Health = health;
            PArmor = pArmor;
            MArmor = mArmor;
            Mobility = mobility;
            Initiative = initiative;
        }

        public override String ToString()
        {
            return ("health : " + Health + ", pArmor : " + PArmor + ", mArmor : " + MArmor + ", mobility : " + Mobility + ", initiative : " + Initiative);
        }
    }
}
