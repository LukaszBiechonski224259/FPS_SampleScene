using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : Interactable
{
    protected override void OnDestroy()
    {
        OnObjectDestroyEvent.AnyFunction();
    }
}
