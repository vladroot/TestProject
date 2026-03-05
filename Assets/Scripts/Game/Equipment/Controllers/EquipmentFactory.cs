using Zenject;

namespace Game.Equipment
{
    public class EquipmentFactory : IFactory<IEquipment>
    {
        public IEquipment Create()
        {
            return new EquipmentController();
        }
    }
}