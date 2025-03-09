namespace Code.Gameplay.Features.TargetCollection
{
    public static class TargetCollectionEntityExtensions
    {
        public static GameEntity RemoveTargetCollectionComponents(this GameEntity entity)
        {
            if (entity.hasTargetBuffer) 
                entity.RemoveTargetBuffer();

            if (entity.hasCollectTargetInterval) 
                entity.RemoveCollectTargetInterval();

            if (entity.hasCollectTargetTimer) 
                entity.RemoveCollectTargetTimer();

            entity.isReadyToCollectTargets = false;

            return entity;
        }
    }
}