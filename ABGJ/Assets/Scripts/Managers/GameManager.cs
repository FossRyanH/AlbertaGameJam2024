using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // This is a temporary enable to allow player movement.
    protected override void Initialize()
    {
        InputManager.Instance.EnableInputType(GameInputType.PlayerControl); 
        InputManager.Instance.DisableInputType(GameInputType.MenuControl);
    }
}
