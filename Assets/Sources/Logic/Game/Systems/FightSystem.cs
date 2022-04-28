using Entitas;

public sealed class FightSystem : IExecuteSystem {

    readonly IGroup<GameEntity> _group;

    public FightSystem(Contexts contexts) {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Target, GameMatcher.Fight));
    }

    public void Execute() {


        foreach (var e in _group.GetEntities())
        {

        }

            foreach (var e in _group.GetEntities()) {
            //var move = e.move;
            //var pos = e.position;
            //e.ReplacePosition(pos.x, pos.y + move.speed, pos.z);
            //e.fight.atk;

            if(e.target.targetEntity == null || e.target.targetEntity.fight.hp < 0)
            {
                
                //e.target.targetEntity = 
            }
        }
    }
}

