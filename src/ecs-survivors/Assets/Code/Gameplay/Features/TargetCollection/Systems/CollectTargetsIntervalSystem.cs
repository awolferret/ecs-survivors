using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.TargetCollection.Systems
{
    public class CollectTargetsIntervalSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _entities;

        public CollectTargetsIntervalSystem(GameContext game,ITimeService time)
        {
            _time = time;
            _entities = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.TargetBuffer,
                    GameMatcher.CollectTargetInterval,
                    GameMatcher.CollectTargetTimer));
        }
        
        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            {
                entity.ReplaceCollectTargetTimer(entity.CollectTargetTimer - _time.DeltaTime);

                if (entity.CollectTargetTimer < 0)
                {
                    entity.isReadyToCollectTargets = true;
                    entity.ReplaceCollectTargetTimer(entity.CollectTargetInterval);
                }
            }   
        }
    }
}