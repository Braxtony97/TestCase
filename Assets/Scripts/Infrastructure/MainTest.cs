using Interfaces;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class MainTest
    {
        [Inject] private IPlayer _player;

        public void ConsoleWrite()
        {
            Debug.Log($"Игрок: {_player.Nickname}, HP: {_player.Health}");
            Debug.Log($"Кол-во предметов: {_player.Equipment.Items.Count}");

            foreach (IItem item in _player.Equipment.Items) 
                Debug.Log(item.Name);
        }
    }
}