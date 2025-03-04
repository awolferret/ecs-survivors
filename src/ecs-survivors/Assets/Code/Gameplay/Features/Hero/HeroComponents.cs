using Code.Gameplay.Features.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Hero
{
    [Game] public class Hero : IComponent { }
    [Game] public class HeroAnimatorComponent : IComponent { public HeroAnimator Value; }
}