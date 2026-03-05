using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace Game.Equipment
{
    [CreateAssetMenu(menuName = "ScriptableObject/Game/Equipment/InverntorySettings", fileName = "InverntorySettings")]
    public class InverntorySettings : ScriptableObject
    {
        [SerializeField] private ItemScriptable[] _items;
        private IEnumerable<IItem> _itemList;

        public IEnumerable<IItem> GetItems()
        {
            _itemList ??= _items.Select(e => e.Item);

            return _itemList;
        }
    }
}