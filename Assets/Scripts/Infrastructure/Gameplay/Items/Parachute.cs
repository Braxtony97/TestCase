namespace Infrastructure.Gameplay.Items
{
    public class Parachute : Item
    {
        // Параметры получаются через DI при вызове Instantiate
        public Parachute(string name = null) : base(name ?? "Parachute") { }
    }
}