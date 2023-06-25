using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookshotController : MonoBehaviour
{
    public Transform playerTransform;  // Reference to the player's transform
    public Transform targetTransform;  // Reference to the target/destination transform
    public float hookshotSpeed = 10f;  // Speed at which the player is pulled towards the target
    //public KeyCode hookshotKey = KeyCode.Space;  // Key to activate the hookshot

    private bool isHookshotActive = false;  // Flag to check if the hookshot is active


    public void ActivateHookshot()
    {
        if (isHookshotActive) return;  // Do nothing if the hookshot is already active

        isHookshotActive = true;
        StartCoroutine(MovePlayerTowardsTarget());
    }

    private IEnumerator MovePlayerTowardsTarget()
    {
        Vector3 initialPosition = playerTransform.position;
        Vector3 targetPosition = targetTransform.position;
        Vector3 hookshotDirection = (targetPosition - initialPosition).normalized;

        float maxDistance = Vector3.Distance(initialPosition, targetPosition);

        while (Vector3.Distance(playerTransform.position, initialPosition) < maxDistance)
        {
            // Move the player towards the target
            playerTransform.position += hookshotDirection * hookshotSpeed * Time.deltaTime;

            yield return null;
        }

        isHookshotActive = false;
    }

}

