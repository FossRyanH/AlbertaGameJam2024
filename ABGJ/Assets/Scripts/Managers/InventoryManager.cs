using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryManager : Singleton<InventoryManager>
{
    public static event Action<List<InventoryItem>> OnInventoryChanged;

    public List<InventoryItem> InventoryItems = new List<InventoryItem>();

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
