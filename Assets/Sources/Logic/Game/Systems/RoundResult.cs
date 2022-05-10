using Entitas;

public sealed class RoundResult : IExecuteSystem {

    readonly IGroup<GameEntity> _group;

    public RoundResult(Contexts contexts) {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Fight));
    }

    public void Execute() {

        foreach (var entity in _group.GetEntities())
        {
            if (entity.fight.hp <= 0)
            {
                //entity.RemoveFight();
                entity.isDestroyed = true;
            }
                
        }

    }
}

