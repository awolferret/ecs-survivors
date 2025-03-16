using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Infrastructure.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Registrars
{
    public class EnemyRegistrar : EntityComponentRegistrar
    {
        public float HP = 3;
        public float Damage = 1;
        public float Speed = 1;
        
        public override void RegisterComponents()
        {
            Entity
                .AddEnemyTypeId(EnemyTypeId.Goblin)
                .AddWorldPosition(transform.position)
                .AddDirection(Vector2.zero)
                .AddSpeed(Speed)
                .AddCurrentHP(HP)
                .AddMaxHP(HP)
                .AddDamage(Damage)
                .AddTargetBuffer(new List<int>(1))
                .AddRadius(0.3f)
                .AddCollectTargetInterval(0.5f)
                .AddCollectTargetTimer(0)
                .AddLayerMask(CollisionLayer.Hero.AsMask())
                .With(x => x.isEnemy = true)
                .With(x => x.isTurnedAlongDirection = true)
                .With(x => x.isMovementAvailable = true)
                ;
        }

        public override void UnRegisterComponents()
        {
            
        }
    }
}