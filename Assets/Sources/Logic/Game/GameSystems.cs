using Entitas;

public class GameSystems : Feature {

    public GameSystems(Contexts contexts) : base("Game Systems") {
        //Add(new AccelerateSystem(contexts));
        //Add(new MoveSystem(contexts));
        //Add(new ReachedFinishSystem(contexts));
        Add(new FindTargetSystem(contexts));
        Add(new FightSystem(contexts));
        //Add(new RoundResult(contexts));
    }
}
