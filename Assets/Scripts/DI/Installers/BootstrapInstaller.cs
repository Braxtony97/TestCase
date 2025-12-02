using Infrastructure;
using UnityEngine;
using Zenject;

namespace DI.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        [SerializeField] private GameBootstrapper _gameBootstrapper;

        public override void InstallBindings()
        {
            Container.Bind<GameBootstrapper>().FromInstance(_gameBootstrapper).AsSingle().NonLazy();
        }
    }
}