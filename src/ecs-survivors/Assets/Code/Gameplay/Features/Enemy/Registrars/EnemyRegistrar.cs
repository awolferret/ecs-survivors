using Code.Common.Extensions;
using Code.Infrastructure.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Registrars
{
    public class EnemyRegistrar : EntityComponentRegistrar
    {
        public float Speed = 1;

        
        public override void RegisterComponents()
        {
            Entity
                .AddEnemyTypeId(EnemyTypeId.Goblin)
                .AddWorldPosition(transform.position)
                .AddDirection(Vector2.zero)
                .AddSpeed(Speed)
                .With(x => x.isEnemy = true)
                .With(x => x.isTurnedAlongDirection = true)
                ;
        }

        public override void UnRegisterComponents()
        {
            
        }
    }
}