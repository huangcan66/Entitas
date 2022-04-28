using Entitas;

public sealed class MoveSystem : IExecuteSystem {

    readonly IGroup<GameEntity> _group;

    public MoveSystem(Contexts contexts) {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Fight));
    }

    public void Execute() {
        foreach (var e in _group.GetEntities()) {
            var move = e.move;
            var pos = e.position;
            e.ReplacePosition(pos.x, pos.y + move.speed, pos.z);
        }
    }
}

