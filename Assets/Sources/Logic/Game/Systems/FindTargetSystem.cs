using Entitas;

public sealed class FindTargetSystem : IExecuteSystem {

    readonly IGroup<GameEntity> _group;

    public FindTargetSystem(Contexts contexts) {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Target, GameMatcher.Camp,GameMatcher.Fight));
    }

    public void Execute() {

        foreach (var e in _group.GetEntities())
        {
            foreach (var enemy in _group.GetEntities())
            {
                if(e.camp.camp != enemy.camp.camp && enemy.fight.hp > 0 ){
                    e.target.targetEntity = enemy;
                    break;
                }
            }
        }

    }
}

