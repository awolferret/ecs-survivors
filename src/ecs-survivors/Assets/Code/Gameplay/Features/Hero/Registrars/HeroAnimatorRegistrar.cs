using Code.Gameplay.Features.Behaviours;
using Code.Infrastructure.Registrars;

namespace Code.Gameplay.Features.Hero.Registrars
{
    public class HeroAnimatorRegistrar : EntityComponentRegistrar
    {
        public HeroAnimator HeroAnimator;

        public override void RegisterComponents()
        {
            Entity
                .AddHeroAnimator(HeroAnimator)
                .AddDamageTakenAnimator(HeroAnimator);
        }

        public override void UnRegisterComponents()
        {
            if (Entity.hasHeroAnimator)
                Entity
                    .RemoveHeroAnimator();
            
            if (Entity.hasDamageTakenAnimator)
                Entity
                    .RemoveDamageTakenAnimator();
        }
    }
}