using Code.Gameplay.Features.Enemy.Behaviours;
using Code.Infrastructure.Registrars;

namespace Code.Gameplay.Features.Enemy.Registrars
{
    public class EnemyAnimatorRegistrar : EntityComponentRegistrar
    {
        public EnemyAnimator EnemyAnimator;
        
        public override void RegisterComponents()
        {
            Entity
                .AddEnemyAnimator(EnemyAnimator);
        }

        public override void UnRegisterComponents()
        {
            Entity
                .RemoveEnemyAnimator();
        }
    }
}