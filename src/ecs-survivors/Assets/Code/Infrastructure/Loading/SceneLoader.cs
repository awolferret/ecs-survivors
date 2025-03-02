using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.Loading
{
  public class SceneLoader : ISceneLoader
  {
    public async UniTask LoadScene(string sceneName, Action onLoaded = null)
    {
      AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
      await asyncOperation.ToUniTask();
      onLoaded?.Invoke();
    }
  }
}