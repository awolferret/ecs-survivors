using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.TargetCollection
{
    [Game] public class TargetBuffer : IComponent { public List<int> Value; }
    [Game] public class ReadyToCollectTargets : IComponent {  }
    [Game] public class CollectTargetInterval : IComponent { public float Value; }
    [Game] public class CollectTargetTimer : IComponent { public float Value; }
    [Game] public class Radius : IComponent { public float Value; }
    [Game] public class LayerMask : IComponent { public int Value; }
}