using UnityEngine;

namespace Game.Equipment
{
    [System.Serializable]
    public abstract class Item : IItem
    {
        public string Name => _name;

        [SerializeField] private string _name;

        public Item(string name)
        {
            _name = name;
        }
    }
}