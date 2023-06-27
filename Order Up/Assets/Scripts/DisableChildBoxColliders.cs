using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableChildBoxColliders : MonoBehaviour
{
    public void TurnOffChildBoxColliders()
    {
        BoxCollider[] childColliders = GetComponentsInChildren<BoxCollider>();

        foreach (BoxCollider collider in childColliders)
        {
            collider.enabled = false;
        }
    }
}
