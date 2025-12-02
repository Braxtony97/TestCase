using Unity.VisualScripting;

namespace Infrastructure.Gameplay.Items
{
    public class RocketPack : Item
    {
        public int Charges { get; }
        
        public RocketPack(int charges, string name = null) : base(name ?? "RocketPack")
        {
            Charges = charges;
        }
    }
}