using System.Collections.Generic;
using Entitas;

namespace Code.Common.Destruct.Systems
{
    public class CleanUpGameDestructedSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private readonly List<GameEntity> _buffer = new(64);

        public CleanUpGameDestructedSystem(GameContext game) =>
            _entities = game.GetGroup(GameMatcher.Destructed);

        public void Cleanup()
        {
            foreach (GameEntity entity in _entities.GetEntities(_buffer))
                entity.Destroy();
        }
    }
}