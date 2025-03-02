﻿using Code.Gameplay;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Input.Service;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private BattleFeature _battleFeature;
        private GameContext _gameContext;
        private ITimeService _timeService;
        private IInputService _inputService;

        [Inject]
        private void Construct(GameContext gameContext,ITimeService timeService,IInputService inputService)
        {
            _gameContext = gameContext;
            _timeService = timeService;
            _inputService = inputService;
        }

        private void Start()
        {
            _battleFeature = new BattleFeature(_gameContext, _timeService, _inputService);
            _battleFeature.Initialize();
        }

        private void Update()
        {
            _battleFeature.Execute();
            _battleFeature.Cleanup();
        }

        private void OnDestroy()
        {
            _battleFeature.TearDown();
        }
    }
}