using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRGrabInteractableCollision : MonoBehaviour
{
    public Collider playerCollider;
    private Collider grabbableCollider;
    private bool isGrabbed;

    private void Start()
    {
        grabbableCollider = GetComponent<Collider>();
    }

    public void SetGrabbedState(bool grabbed)
    {
        isGrabbed = grabbed;

        if (grabbed)
        {
            Physics.IgnoreCollision(playerCollider, grabbableCollider, true);
        }
        else
        {
            Physics.IgnoreCollision(playerCollider, grabbableCollider, false);
        }
    }
}
