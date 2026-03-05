using System.Collections.Generic;

namespace Game.Equipment
{
    public interface IEquipment
    {
        IEnumerable<IItem> Items { get; }
        void AddItem(IItem item);
    }
}