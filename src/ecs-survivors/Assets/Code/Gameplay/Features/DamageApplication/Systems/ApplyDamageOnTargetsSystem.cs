using Entitas;

namespace Code.Gameplay.Features.DamageApplication.Systems
{
    public class ApplyDamageOnTargetsSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly IGroup<GameEntity> _damageDealers;

        public ApplyDamageOnTargetsSystem(GameContext game)
        {
            _game = game;
            _damageDealers = _game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Damage,
                    GameMatcher.TargetBuffer));
        }
        
        public void Execute()
        {
            foreach (GameEntity damageDealer in _damageDealers)
            foreach (int targetId in damageDealer.TargetBuffer)
            {
                GameEntity target = _game.GetEntityWithId(targetId);

                if (target.hasCurrentHP)
                {
                    target.ReplaceCurrentHP(target.CurrentHP - damageDealer.Damage);

                    if (target.hasDamageTakenAnimator) 
                        target.DamageTakenAnimator.PlayDamageTaken();
                }
            }
        }
    }
}