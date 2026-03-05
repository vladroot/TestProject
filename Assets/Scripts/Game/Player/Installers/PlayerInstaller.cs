using UnityEngine;
using Zenject;

namespace Game.Player
{
    [CreateAssetMenu(menuName = "Installers/Game/Player/PlayerInstaller", fileName = "PlayerInstaller")]
    public class PlayerInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private PlayerSettings _playerSettings;

        public override void InstallBindings()
        {
            Container.BindInstance(_playerSettings).AsSingle();
            Container.BindInterfacesTo<PlayerController>().AsSingle();
        }
    }
}