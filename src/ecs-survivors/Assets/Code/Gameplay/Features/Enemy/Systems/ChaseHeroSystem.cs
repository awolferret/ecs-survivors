﻿using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
    public class ChaseHeroSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _enemies;
        private readonly IGroup<GameEntity> _heroes;

        public ChaseHeroSystem(GameContext game)
        {
            _enemies = game.GetGroup(GameMatcher.
                AllOf(
                    GameMatcher.Enemy,
                    GameMatcher.WorldPosition));

            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.WorldPosition));
        }
        
        public void Execute()
        {
            foreach (GameEntity hero in _heroes)
            foreach (GameEntity enemy in _enemies)
            {
                enemy.ReplaceDirection((hero.WorldPosition - enemy.WorldPosition).normalized);
                enemy.isMoving = true;
            }
        }
    }
}