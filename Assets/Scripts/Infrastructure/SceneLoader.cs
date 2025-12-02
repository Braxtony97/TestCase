using System;
using System.Collections;
using Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Infrastructure
{
    public class SceneLoader
    {
        private readonly ICoroutineRunner _coroutineRunner;

        [Inject]
        public SceneLoader(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }

        public void LoadScene (string scene, Action onLoaded = null)
        {
            _coroutineRunner.StartCoroutine(LoadSceneWithCoroutine(scene, onLoaded));
        }

        private IEnumerator LoadSceneWithCoroutine(string scene, Action onLoaded) 
        {
            string sceneName = scene.ToString();

            if (SceneManager.GetActiveScene().name == sceneName)
            {
                onLoaded?.Invoke();
                yield break;
            }

            AsyncOperation waitNextScene = SceneManager.LoadSceneAsync(sceneName);

            while (!waitNextScene.isDone)
            {
                yield return null;
            }

            onLoaded?.Invoke();
        }
    }
}