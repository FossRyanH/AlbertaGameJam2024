using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "MenuControlChannelSO", menuName = "SO/Inputs/MenuInputs", order = 1)]
public class MenuInputChannelSO : ScriptableObject
{
    public event Action Open, Close, Select;

    public void HandleOpenMenu() => Open?.Invoke();
    public void HandleCloseMenu() => Close?.Invoke();
    public void HandleSelect() => Select?.Invoke();
}
