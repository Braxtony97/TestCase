using Interfaces;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    // В этот класс DI внедряет экземпляр игрока.
    // Это демонстрирует использование Player из любой части программы
    public class MainTest
    {
        [Inject] private IPlayer _player;

        public void ConsoleWrite()
        {
            Debug.Log($"Игрок: {_player.Nickname}, HP: {_player.Health}");
            Debug.Log($"Кол-во предметов: {_player.Equipment.Items.Count}");
            
            // Легко менять значения атрибутов игрока из разных частей программы
            // IPlayer будет доступен только в пределах SceneContext
            _player.Nickname = "Leo";
            _player.Health = 20;
            
            Debug.Log($"После изменении: Игрок: {_player.Nickname}, HP: {_player.Health}");

            foreach (IItem item in _player.Equipment.Items) 
                Debug.Log(item.Name);
        }
    }
}