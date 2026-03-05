using System.Collections.Generic;

namespace Game.Equipment
{
    public class EquipmentController : IEquipment
    {
        public IEnumerable<IItem> Items => _items;

        private readonly List<IItem> _items;

        public EquipmentController()
        {
            _items = new List<IItem>();
        }

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }
    }
}