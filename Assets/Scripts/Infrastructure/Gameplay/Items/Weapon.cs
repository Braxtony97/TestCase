namespace Infrastructure.Gameplay.Items
{
    public class Weapon : Item
    {
        public int Ammo { get; }

        // Параметры получаются через DI при вызове Instantiate
        public Weapon(string name, int ammo) : base(name)
        {
            Ammo = ammo;
        }
    }
}