using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerControlsListener
{
    void Movement(Vector2 movement);
    void Interact();
    void Interact2();
    void Attack();
}
