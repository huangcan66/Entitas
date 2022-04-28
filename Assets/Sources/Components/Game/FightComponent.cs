using Entitas;
using UnityEngine;

[Game]
public sealed class FightComponent : IComponent
{
    public int atk;
    public int def;
    public int hp;
    public int range;
}