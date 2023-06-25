using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 50f;

    private bool isRotating = false;

    private void Start()
    {
        StartRotation();
    }

    private void StartRotation()
    {
        if (!isRotating)
        {
            StartCoroutine(SpinCoin());
        }
    }

    private IEnumerator SpinCoin()
    {
        isRotating = true;

        while (true)
        {
            // Rotate around its local Y-axis
            transform.rotation *= Quaternion.Euler(0f, rotationSpeed * Time.deltaTime, 0f);
            yield return null;
        }
    }
}
