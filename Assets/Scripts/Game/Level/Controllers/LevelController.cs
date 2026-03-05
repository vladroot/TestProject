using Game.Equipment;
using Game.Player;
using Zenject;

namespace Game.Level
{
    public class LevelController : IInitializable
    {
        private readonly IPlayer _player;
        private readonly string[] _skills;
        private readonly InverntorySettings _inventorySettings;

        public LevelController(IPlayer player, string[] skills, InverntorySettings inventorySettings)
        {
            _player = player;
            _skills = skills;
            _inventorySettings = inventorySettings;
        }

        public void Initialize()
        {
            foreach (var item in _inventorySettings.GetItems())
                _player.Equipment.AddItem(item);
            foreach (string skill in _skills)
                _player.AddSkill(skill);
        }
    }
}