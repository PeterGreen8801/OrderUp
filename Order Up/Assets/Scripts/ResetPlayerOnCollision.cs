using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerOnCollision : MonoBehaviour
{
    public Transform startPoint; // Reference to the starting point of the level

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            // Teleport the player back to the starting point
            transform.position = startPoint.position;
            transform.rotation = startPoint.rotation;
        }
    }


}
