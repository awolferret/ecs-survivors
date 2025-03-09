using Code.Gameplay.Features.Enemy.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Enemy
{
    public class EnemyFeature : Feature
    {
        public EnemyFeature(ISystemFactory systems)
        {
            Add(systems.Create<ChaseHeroSystem>());
        }
    }
}