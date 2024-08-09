using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestItem : Item
{
    public static event Action<ItemData> OnTestItemPickup;

    public override void Collection()
    {
        Destroy(this.gameObject);
        OnTestItemPickup?.Invoke(itemData);
    }
}
