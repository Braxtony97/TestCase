using Infrastructure;
using Interfaces;
using UnityEngine;
using Zenject;

namespace DI.Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private SceneConfig _boot;
        [SerializeField] private SceneConfig _playmode;
        
        [SerializeField] private CoroutineRunner _coroutineRunner;
        
        public override void InstallBindings()
        {
            ComponentsBindings();
            SceneBindings();
            
            Container.Bind<SceneLoader>().AsSingle();
        }

        private void ComponentsBindings()
        {
            Container.Bind<ICoroutineRunner>().FromInstance(_coroutineRunner).AsSingle().NonLazy();
        }

        private void SceneBindings()
        {
            Container.Bind<SceneConfig>().WithId("Boot").FromInstance(_boot);
            Container.Bind<SceneConfig>().WithId("Playmode").FromInstance(_playmode);
        }
    }
}
