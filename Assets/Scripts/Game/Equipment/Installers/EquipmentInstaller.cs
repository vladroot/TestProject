using UnityEngine;
using Zenject;

namespace Game.Equipment
{
    [CreateAssetMenu(menuName = "Installers/Game/Equipment/EquipmentInstaller", fileName = "EquipmentInstaller")]
    public class EquipmentInstaller : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IEquipment>().FromFactory<EquipmentFactory>().AsCached();
        }
    }
}