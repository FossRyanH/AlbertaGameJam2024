using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, ICollectible
{
    [SerializeField] protected ItemData itemData;
    [SerializeField] protected AudioClip itemPickupSound;
    
    public virtual void Collection() {}
}
