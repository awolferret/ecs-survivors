//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCollectTargetInterval;

    public static Entitas.IMatcher<GameEntity> CollectTargetInterval {
        get {
            if (_matcherCollectTargetInterval == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CollectTargetInterval);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCollectTargetInterval = matcher;
            }

            return _matcherCollectTargetInterval;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Features.TargetCollection.CollectTargetInterval collectTargetInterval { get { return (Code.Gameplay.Features.TargetCollection.CollectTargetInterval)GetComponent(GameComponentsLookup.CollectTargetInterval); } }
    public float CollectTargetInterval { get { return collectTargetInterval.Value; } }
    public bool hasCollectTargetInterval { get { return HasComponent(GameComponentsLookup.CollectTargetInterval); } }

    public GameEntity AddCollectTargetInterval(float newValue) {
        var index = GameComponentsLookup.CollectTargetInterval;
        var component = (Code.Gameplay.Features.TargetCollection.CollectTargetInterval)CreateComponent(index, typeof(Code.Gameplay.Features.TargetCollection.CollectTargetInterval));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceCollectTargetInterval(float newValue) {
        var index = GameComponentsLookup.CollectTargetInterval;
        var component = (Code.Gameplay.Features.TargetCollection.CollectTargetInterval)CreateComponent(index, typeof(Code.Gameplay.Features.TargetCollection.CollectTargetInterval));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveCollectTargetInterval() {
        RemoveComponent(GameComponentsLookup.CollectTargetInterval);
        return this;
    }
}
