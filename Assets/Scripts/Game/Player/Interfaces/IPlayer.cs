using System.Collections.Generic;
using Game.Equipment;

namespace Game.Player
{
    public interface IPlayer
    {
        int Health { get; }
        int Lives { get; }
        string Nickname { get; }
        List<string> Skills { get; }
        IEquipment Equipment { get; }

        void AddSkill(string skill);
    }
}