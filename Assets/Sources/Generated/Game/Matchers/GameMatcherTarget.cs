//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class GameMatcher {

    static IMatcher<GameEntity> _matcherTarget;

    public static IMatcher<GameEntity> Target {
        get {
            if(_matcherTarget == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.Target);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTarget = matcher;
            }

            return _matcherTarget;
        }
    }
}