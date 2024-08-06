using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "PlayerControlChannelSO", menuName = "SO/Inputs/PlayerInputs", order = 0)]
public class PlayerInputChannelSO : ScriptableObject
{
    public event Action<Vector2> Movement;
    public event Action Interact, Interact2, Attack;

    public void HandleMovement(Vector2 movement) => Movement?.Invoke(movement);
    public void HandleInteract() => Interact?.Invoke();
    public void HandleInteract2() => Interact2?.Invoke();
    public void HandleAttack() => Attack?.Invoke();
}
