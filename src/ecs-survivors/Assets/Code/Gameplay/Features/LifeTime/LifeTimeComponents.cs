﻿using Entitas;

namespace Code.Gameplay.Features.LifeTime
{
    [Game] public class MaxHP : IComponent { public float Value; }
    [Game] public class CurrentHP : IComponent { public float Value; }
    [Game] public class Dead : IComponent { }
    [Game] public class ProcessingDeath : IComponent { }
}