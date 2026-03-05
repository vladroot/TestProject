using System.Collections.Generic;
using Game.Equipment;

namespace Game.Player
{
    public class PlayerController : IPlayer
    {
        public int Health { get; set; }
        public int Lives { get; set; }
        public string Nickname { get; private set; }
        public List<string> Skills { get; private set; }
        public IEquipment Equipment { get; private set; }

        public PlayerController(PlayerSettings settings, IEquipment equipment)
        {
            Nickname = settings.Nickname;
            Health = settings.Health;
            Lives = settings.Lives;
            Equipment = equipment;
            Skills = new List<string>();
        }

        public void AddSkill(string skill)
        {
            if (Skills.Contains(skill))
                return;

            Skills.Add(skill);
        }
    }
}