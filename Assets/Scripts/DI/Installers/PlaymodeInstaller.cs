using Infrastructure.Gameplay;
using Infrastructure.Gameplay.Items;
using Interfaces;
using Zenject;

namespace DI.Installers
{
    public class PlaymodeInstaller : MonoInstaller
    {
        // Зависимости в пределах SceneContext
        public override void InstallBindings()
        {
            // Каждый предмет экипировки создаётся как временный объект
            // Это позволяет передавать параметры в конструктор в рантайме
            Container.Bind<Weapon>().AsTransient();
            Container.Bind<Parachute>().AsTransient();
            Container.Bind<RocketPack>().AsTransient();
            
            // Регистрируем Equipment по интерфейсу
            // AsSingle обеспечивает "безопасный Singleton", создаваемый контейнером DI. Один общий объект
            Container.Bind<IEquipment>().To<Equipment>().AsSingle();
            
            // Регистрируем Player по интерфейсу
            // AsSingle обеспечивает "безопасный Singleton", создаваемый контейнером DI. Один общий объект
            Container.Bind<IPlayer>().To<Player>().AsSingle();
        }
    }
}