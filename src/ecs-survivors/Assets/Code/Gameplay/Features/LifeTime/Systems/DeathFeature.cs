using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.LifeTime.Systems
{
    public class DeathFeature : Feature
    {
        public DeathFeature(ISystemFactory systems)
        {
            Add(systems.Create<MarkDeadSystem>());
        }
    }
}