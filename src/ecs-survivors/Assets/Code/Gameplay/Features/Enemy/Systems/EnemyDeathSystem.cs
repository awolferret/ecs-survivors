﻿using Code.Gameplay.Features.TargetCollection;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
    public class EnemyDeathSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _enemies;

        public EnemyDeathSystem(GameContext game)
        {
            _enemies = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Enemy
                    , GameMatcher.Dead
                    , GameMatcher.ProcessingDeath));
        }
        
        public void Execute()
        {
            foreach (GameEntity enemy in _enemies)
            {
                enemy.RemoveTargetCollectionComponents();
                enemy.isMovementAvailable = false;
                enemy.isTurnedAlongDirection = false;
                
                if (enemy.hasEnemyAnimator) 
                    enemy.EnemyAnimator.PlayDied();

                enemy.ReplaceSelfDestructTimer(2);
            }
        }
    }
}