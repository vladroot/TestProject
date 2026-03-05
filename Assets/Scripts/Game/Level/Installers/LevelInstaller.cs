using Game.Equipment;
using UnityEngine;
using Zenject;

namespace Game.Level
{
    [CreateAssetMenu(menuName = "Installers/Game/Level/LevelInstaller", fileName = "LevelInstaller")]
    public class LevelInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private string[] _skills;
        [SerializeField] private InverntorySettings _inventorySettings;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<LevelController>().AsSingle().WithArguments(_skills, _inventorySettings).NonLazy();
        }
    }
}