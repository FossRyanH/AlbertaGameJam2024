using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerControlsListener
{
    [Header("Scriptable Objects")]
    [SerializeField] private PlayerInputChannelSO playerInputs;

    [Header("Components")]
    [SerializeField] private Rigidbody2D rB;

    [Header("Movement Variables")]
    [SerializeField] private float moveSpeed = 175f;

    private Vector2 _inputDir;

    private void OnEnable()
    {
        RegisterListeners();
    }

    private void OnDisable()
    {
        DeRegisterListeners();
    }

    private void Awake()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    void RegisterListeners()
    {
        playerInputs.Movement += Movement;
        playerInputs.Attack += Attack;
        playerInputs.Interact += Interact;
        playerInputs.Interact2 += Interact2;
    }

    void DeRegisterListeners()
    {
        playerInputs.Movement -= Movement;
        playerInputs.Attack -= Attack;
        playerInputs.Interact -= Interact;
        playerInputs.Interact2 -= Interact2;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rB.velocity = _inputDir * moveSpeed * Time.fixedDeltaTime;
    }

    public void Movement(Vector2 movement)
    {
        _inputDir = movement;
        _inputDir.Normalize();
    }

    public void Interact() {  }

    public void Interact2() {  }

    public void Attack() {  }
}
