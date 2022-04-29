//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CampComponent camp { get { return (CampComponent)GetComponent(GameComponentsLookup.Camp); } }
    public bool hasCamp { get { return HasComponent(GameComponentsLookup.Camp); } }

    public void AddCamp(int newCamp) {
        var component = CreateComponent<CampComponent>(GameComponentsLookup.Camp);
        component.camp = newCamp;
        AddComponent(GameComponentsLookup.Camp, component);
    }

    public void ReplaceCamp(int newCamp) {
        var component = CreateComponent<CampComponent>(GameComponentsLookup.Camp);
        component.camp = newCamp;
        ReplaceComponent(GameComponentsLookup.Camp, component);
    }

    public void RemoveCamp() {
        RemoveComponent(GameComponentsLookup.Camp);
    }
}
