using UnityEngine;

namespace Game.Equipment
{
    [System.Serializable]
    public class Weapon : Item
    {
        public int Ammo => _ammo;

        [SerializeField] private int _ammo;

        public Weapon(string name, int ammo) : base(name)
        {
            _ammo = ammo;
        }

        public bool Shoot()
        {
            if (_ammo == 0)
                return false;

            _ammo--;

            return true;
        }
    }
}