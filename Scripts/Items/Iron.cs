using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : Interactable
{
    public override void Interact()
    {
        base.Interact();

        Debug.Log("Mining ore");   // Pick it up!
    }
}
