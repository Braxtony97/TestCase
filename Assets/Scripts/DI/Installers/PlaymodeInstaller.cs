using Infrastructure.Gameplay;
using Infrastructure.Gameplay.Items;
using Interfaces;
using Zenject;

namespace DI.Installers
{
    public class PlaymodeInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Weapon>().AsTransient();
            Container.Bind<Parachute>().AsTransient();
            Container.Bind<RocketPack>().AsTransient();
            
            Container.Bind<IEquipment>().To<Equipment>().AsSingle();
            Container.Bind<IPlayer>().To<Player>().AsSingle();
        }
    }
}