using Interfaces;
using Zenject;

namespace Infrastructure.Gameplay
{
    public class Player : IPlayer
    {
        public int Health { get; set; }
        public int Lives { get; set; }
        public string Nickname { get; set; }
        public string[] Skills { get; set; }
        public IEquipment Equipment { get; }
        
        [Inject]
        public Player(IEquipment equipment)
        {
            Equipment = equipment;
        }
    }
}