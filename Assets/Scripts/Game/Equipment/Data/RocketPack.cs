using UnityEngine;

namespace Game.Equipment
{
    [System.Serializable]
    public class RocketPack : Item
    {
        public int Charges => _charges;

        [SerializeField] private int _charges;

        public RocketPack(string name, int charges) : base(name)
        {
            _charges = charges;
        }

        public bool Activate()
        {
            if (_charges == 0)
                return false;

            _charges--;

            return true;
        }
    }
}