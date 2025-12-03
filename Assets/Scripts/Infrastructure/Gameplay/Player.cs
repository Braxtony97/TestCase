using Interfaces;
using Zenject;

namespace Infrastructure.Gameplay
{
    public class Player : IPlayer
    {
        // Игрок создаётся и управляется DI-контейнером
        // Благодаря DI мы избегаем статических синглтонов и сохраняем уникальность экземпляра
        
        public int Health { get; set; }
        public int Lives { get; set; }
        public string Nickname { get; set; }
        public string[] Skills { get; set; }
        public IEquipment Equipment { get; }
        
        
        // Экипировка внедряется через конструктор
        // Это соответствует принципу Dependency Inversion (DIP) - конкретные классы внедряются контейнером Zenject
        [Inject]
        public Player(IEquipment equipment)
        {
            Equipment = equipment;
        }
    }
}