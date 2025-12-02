namespace Infrastructure.Gameplay.Items
{
    public class Weapon : Item
    {
        public int Ammo { get; }

        public Weapon(string name, int ammo) : base(name)
        {
            Ammo = ammo;
        }
    }
}