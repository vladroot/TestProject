using UnityEngine;

namespace Game.Equipment
{
    [System.Serializable]
    public class GenericItemScriptable<T> : ItemScriptable where T : IItem
    {
        public override IItem Item => _item;

        [SerializeField] protected T _item;
    }

    [System.Serializable]
    public abstract class ItemScriptable : ScriptableObject
    {
        public abstract IItem Item { get; }
    }
}