//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TargetComponent target { get { return (TargetComponent)GetComponent(GameComponentsLookup.Target); } }
    public bool hasTarget { get { return HasComponent(GameComponentsLookup.Target); } }

    public void AddTarget(GameEntity newTargetEntity) {
        var component = CreateComponent<TargetComponent>(GameComponentsLookup.Target);
        component.targetEntity = newTargetEntity;
        AddComponent(GameComponentsLookup.Target, component);
    }

    public void ReplaceTarget(GameEntity newTargetEntity) {
        var component = CreateComponent<TargetComponent>(GameComponentsLookup.Target);
        component.targetEntity = newTargetEntity;
        ReplaceComponent(GameComponentsLookup.Target, component);
    }

    public void RemoveTarget() {
        RemoveComponent(GameComponentsLookup.Target);
    }
}
