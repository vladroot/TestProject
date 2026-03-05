using UnityEngine;

namespace Game.Player
{
    [CreateAssetMenu(menuName = "ScriptableObject/Game/Player/PlayerSettings", fileName = "PlayerSettings")]
    public class PlayerSettings : ScriptableObject
    {
        public string Nickname => _nickname;
        public int Health => _health;
        public int Lives => _lives;

        [SerializeField] private string _nickname;
        [SerializeField] private int _health;
        [SerializeField] private int _lives;
    }
}