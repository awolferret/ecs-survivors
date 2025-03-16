using Code.Common.Extensions;
using Code.Infrastructure.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Registrars
{
    public class HeroRegistrar : EntityComponentRegistrar
    {
        public float MaxHp = 100;
        public float Speed = 2;
        
        public override void RegisterComponents()
        {
            Entity
                .AddWorldPosition(transform.position)
                .AddDirection(Vector2.zero)
                .AddSpeed(Speed)
                .AddCurrentHP(MaxHp)
                .AddMaxHP(MaxHp)
                .With(x => x.isHero = true)
                .With(x => x.isTurnedAlongDirection = true)
                .With(x => x.isMovementAvailable = true)
                ;
        }

        public override void UnRegisterComponents()
        {
        }
    }
}