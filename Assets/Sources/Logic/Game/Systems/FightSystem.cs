using Entitas;

public sealed class FightSystem : IExecuteSystem {

    readonly IGroup<GameEntity> _group;

    public FightSystem(Contexts contexts) {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Target, GameMatcher.Fight));
    }

    public void Execute() {

        foreach (var entity in _group.GetEntities())
        {
            if (entity.target.targetEntity != null && entity.fight.hp > 0) { 

                var hit = entity.fight.atk - entity.target.targetEntity.fight.def;
                if (hit < 0)
                {
                    hit = 1;
                }
                entity.target.targetEntity.fight.hp -= hit;

                if (entity.target.targetEntity.fight.hp <= 0)
                {
                    entity.target.targetEntity = null;
                }
                    
            }

        }

        //foreach (var entity in _group.GetEntities())
        //{
        //    if (entity.fight.hp <= 0)
        //        entity.RemoveFight();
        //}

    }
}

