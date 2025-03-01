using Code.Gameplay.Cameras;
using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Input.Service;
using Code.Gameplay.Levels;
using Code.Gameplay.StaticData;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Identifiers;
using Code.Infrastructure.Loading;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class BootstrapInstaller : MonoInstaller , IInitializable
    {
        public override void InstallBindings()
        {
            BindContext();
            BindCameraProvider();
            BindGameplayServices();
            BindInfrastructureServices();
            BindAssetManagementServices();
            BindCommonServices();
            BindInputService();
        }

        private void BindContext()
        {
            Container
                .Bind<Contexts>()
                .FromInstance(Contexts.sharedInstance)
                .AsSingle();

            Container
                .Bind<GameContext>()
                .FromInstance(Contexts.sharedInstance.game)
                .AsSingle();
        }

        private void BindCameraProvider()
        {
            Container
                .BindInterfacesAndSelfTo<CameraProvider>()
                .AsSingle();
        }

        private void BindGameplayServices()
        {
            Container
                .Bind<IStaticDataService>()
                .To<StaticDataService>()
                .AsSingle();

            Container
                .Bind<ILevelDataProvider>()
                .To<LevelDataProvider>()
                .AsSingle();
        }

        private void BindInfrastructureServices()
        {
            Container
                .BindInterfacesAndSelfTo<BootstrapInstaller>()
                .FromInstance(this)
                .AsSingle();

            Container
                .Bind<IIdentifierService>()
                .To<IdentifierService>()
                .AsSingle();
        }

        private void BindAssetManagementServices()
        {
            Container
                .Bind<IAssetProvider>()
                .To<AssetProvider>()
                .AsSingle();
        }

        private void BindCommonServices()
        {
            Container
                .Bind<IRandomService>()
                .To<UnityRandomService>()
                .AsSingle();
            
            Container
                .Bind<ICollisionRegistry>()
                .To<CollisionRegistry>()
                .AsSingle();
            
            Container
                .Bind<IPhysicsService>()
                .To<PhysicsService>()
                .AsSingle();
            
            Container
                .Bind<ITimeService>()
                .To<UnityTimeService>()
                .AsSingle();
            
            Container
                .Bind<ISceneLoader>()
                .To<SceneLoader>()
                .AsSingle();
        }

        private void BindInputService()
        {
            Container
                .Bind<IInputService>()
                .To<StandaloneInputService>()
                .AsSingle();
        }

        public void Initialize()
        {
            Container
                .Resolve<IStaticDataService>()
                .LoadAll();
            
            Container
                .Resolve<ISceneLoader>()
                .LoadScene("");
        }
    }
}
