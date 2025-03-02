using System;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.Loading
{
  public interface ISceneLoader
  {
    UniTask LoadScene(string name, Action onLoaded = null);
  }
}