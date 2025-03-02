﻿using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Cameras.Systems
{
    public class CameraFollowHeroSystem : IExecuteSystem
    {
        private readonly ICameraProvider _cameraProvider;
        private readonly IGroup<GameEntity> _heroes;

        public CameraFollowHeroSystem(GameContext gameContext, ICameraProvider cameraProvider)
        {
            _cameraProvider = cameraProvider;
            _heroes = gameContext.GetGroup(GameMatcher
                .AllOf(GameMatcher.Hero,
                    GameMatcher.WorldPosition));
        }
        
        public void Execute()
        {
            foreach (GameEntity hero in _heroes)
            {
                _cameraProvider.MainCamera.transform.SetWorldXY(hero.WorldPosition.x, hero.WorldPosition.y);
            }
        }
    }
}