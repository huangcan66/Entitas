using Entitas;
using UnityEngine;

[Game]
public sealed class FightComponent : IComponent
{
    public int hp;
    public int atk;
    public int def;
}