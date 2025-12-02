using Infrastructure.Gameplay.Items;
using Interfaces;
using UnityEngine;
using Zenject;

namespace Infrastructure.Gameplay
{
    public class GameInitializer : MonoBehaviour
    {
        [Inject] private IPlayer _player;
        [Inject] private DiContainer _container;

        private void Start()
        {
            CreatePlayer();
            CreateItems();
            CallConsoleWrite();
        }

        private void CallConsoleWrite()
        {
            var test = _container.Instantiate<MainTest>();
            test.ConsoleWrite();
        }

        private void CreatePlayer()
        {
            _player.Health = 100;
            _player.Lives = 3;
            _player.Nickname = "John";
            _player.Skills = new[] { "Skill1", "Skill2", "Skill3" };
        }

        private void CreateItems()
        {
            var rifle = _container.Instantiate<Weapon>(new object[] { "Blaster", 50 });
            var parachute = _container.Instantiate<Parachute>();
            var rocketPack = _container.Instantiate<RocketPack>(new object[] { 3 });
            
            _player.Equipment.AddItem(rifle);
            _player.Equipment.AddItem(parachute);
            _player.Equipment.AddItem(rocketPack);
        }
    }
}