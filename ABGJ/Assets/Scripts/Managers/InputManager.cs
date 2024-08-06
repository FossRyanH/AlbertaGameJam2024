using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>
{
    #region Input Objects
    [SerializeField] private PlayerInputChannelSO playerInputsSO;
    #endregion
    
    #region InputTypes and Actions
    private GameInputs _gameInput;
    private GameInputType _gameInputType;
    private Dictionary<GameInputType, InputActionMap> _actionMaps;
    #endregion

    protected override void Initialize()
    {
        if (_actionMaps == null)
        {
            _actionMaps = new Dictionary<GameInputType, InputActionMap>();
        }

        if (_gameInput == null)
        {
            _gameInput = new GameInputs();
            //Player controls
            _gameInput.PlayerInputs.Movement.performed += (ctx) => playerInputsSO.HandleMovement(ctx.ReadValue<Vector2>());
            _gameInput.PlayerInputs.Interact.performed += (ctx) => playerInputsSO.HandleInteract();
            _gameInput.PlayerInputs.Interact2.performed += (ctx) => playerInputsSO.HandleInteract2();
            _gameInput.PlayerInputs.Attack.performed += (ctx) => playerInputsSO.HandleAttack();
            //Add player Inputs to the action mapping.
            _actionMaps.Add(GameInputType.PlayerControl, _gameInput.PlayerInputs);
        }
        _gameInput.Enable();
    }

    public void EnableInputType(GameInputType inputType)
    {
        _actionMaps[inputType].Enable();
    }

    public void DisableInputType(GameInputType inputType)
    {
        _actionMaps[inputType].Disable();
    }
}

public enum GameInputType { PlayerControl, MenuControl }
