using Entitas;
using UnityEngine;

[Game]
public sealed class TargetComponent : IComponent
{
    public GameEntity targetEntity;
}