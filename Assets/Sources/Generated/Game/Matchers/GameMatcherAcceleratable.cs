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

    static IMatcher<GameEntity> _matcherAcceleratable;

    public static IMatcher<GameEntity> Acceleratable {
        get {
            if(_matcherAcceleratable == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.Acceleratable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAcceleratable = matcher;
            }

            return _matcherAcceleratable;
        }
    }
}
