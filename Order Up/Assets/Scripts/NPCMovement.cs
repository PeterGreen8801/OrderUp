using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 2f;

    private bool movingToEndPoint = true;

    private void Start()
    {
        StartCoroutine(MoveNPC());
    }

    private System.Collections.IEnumerator MoveNPC()
    {
        while (true)
        {
            // Calculate the target position based on the current movement direction
            Vector3 targetPosition = movingToEndPoint ? endPoint.position : startPoint.position;

            // Move towards the target position
            while (transform.position != targetPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                yield return null;
            }

            // Change movement direction
            movingToEndPoint = !movingToEndPoint;

            // Rotate the NPC to face the new movement direction
            transform.forward = (movingToEndPoint ? endPoint.position - startPoint.position : startPoint.position - endPoint.position).normalized;

            yield return null;
        }
    }
}

