using Entitas;
using UnityEngine;

public sealed class InitOpponentsSystem : IInitializeSystem {

    readonly GameContext _context;

    public InitOpponentsSystem(Contexts contexts) {
        _context = contexts.game;
    }

    public void Initialize() {
        const string resourceName = "Opponent";
        for(int i = 1; i <= 3; i++) {
            //var speed = Random.value * 0.02f;
            var e = _context.CreateEntity();
            e.AddAsset(resourceName);
            e.AddPosition(i*2, 0, 0);
            //e.AddMove(speed, speed);
            e.AddFight(10, 1, 1);
            e.AddTarget(null);
            e.AddCamp(1);
           
        }
    }
}
