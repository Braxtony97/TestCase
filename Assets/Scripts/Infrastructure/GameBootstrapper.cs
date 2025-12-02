using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        [Inject] private SceneLoader _sceneLoader;
        [Inject(Id = "Playmode")] private SceneConfig _bootConfig;

        private void Awake()
        {
            Application.targetFrameRate = 60;
            LoadGame();
        }

        private void LoadGame()
        {
            _sceneLoader.LoadScene(_bootConfig.SceneName);
        }
    }
}