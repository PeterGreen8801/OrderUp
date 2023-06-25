using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullPlayer : MonoBehaviour
{
    public Transform target;

    public GameObject player;

    public void movePlayer()
    {
        player.transform.position = target.transform.position;
    }
}
