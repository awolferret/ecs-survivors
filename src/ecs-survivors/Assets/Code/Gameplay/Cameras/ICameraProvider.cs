namespace Code.Gameplay.Cameras
{
  public interface ICameraProvider
  {
    UnityEngine.Camera MainCamera { get; }
    float WorldScreenHeight { get; }
    float WorldScreenWidth { get; }
    void SetMainCamera(UnityEngine.Camera camera);
  }
}