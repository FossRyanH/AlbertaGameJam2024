using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ItemData", menuName = "SO/Items/ItemData", order = 0)]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public string ItemQuantity;
    public Sprite ItemIcon;
}
