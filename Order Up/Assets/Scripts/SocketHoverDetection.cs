using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR;

public class SocketHoverDetection : MonoBehaviour
{
    public HapticImpulse hapticImpulse; // Reference to the HapticImpulse script

    private XRDirectInteractor leftHandInteractor;
    private XRDirectInteractor rightHandInteractor;

    private void Awake()
    {
        // Get references to the XRDirectInteractor components on the left and right hands
        leftHandInteractor = GameObject.FindGameObjectWithTag("LeftDirectInteractor").GetComponent<XRDirectInteractor>();
        rightHandInteractor = GameObject.FindGameObjectWithTag("RightDirectInteractor").GetComponent<XRDirectInteractor>();
    }

    [System.Obsolete]
    private void OnEnable()
    {
        if (leftHandInteractor != null)
        {
            // Subscribe to hover events for the left hand
            leftHandInteractor.onHoverEntered.AddListener(OnHoverEnterLeft);
            leftHandInteractor.onHoverExited.AddListener(OnHoverExitLeft);
        }

        if (rightHandInteractor != null)
        {
            // Subscribe to hover events for the right hand
            rightHandInteractor.onHoverEntered.AddListener(OnHoverEnterRight);
            rightHandInteractor.onHoverExited.AddListener(OnHoverExitRight);
        }
    }

    [System.Obsolete]
    private void OnDisable()
    {
        if (leftHandInteractor != null)
        {
            // Unsubscribe from hover events for the left hand
            leftHandInteractor.onHoverEntered.RemoveListener(OnHoverEnterLeft);
            leftHandInteractor.onHoverExited.RemoveListener(OnHoverExitLeft);
        }

        if (rightHandInteractor != null)
        {
            // Unsubscribe from hover events for the right hand
            rightHandInteractor.onHoverEntered.RemoveListener(OnHoverEnterRight);
            rightHandInteractor.onHoverExited.RemoveListener(OnHoverExitRight);
        }
    }

    private void OnHoverEnterLeft(XRBaseInteractable interactable)
    {
        // Left hand is hovering on the socket
        hapticImpulse.BasictHapticImpulse();
    }

    private void OnHoverExitLeft(XRBaseInteractable interactable)
    {
        // Left hand is no longer hovering on the socket
    }

    private void OnHoverEnterRight(XRBaseInteractable interactable)
    {
        // Right hand is hovering on the socket
        hapticImpulse.BasictHapticImpulse();
    }

    private void OnHoverExitRight(XRBaseInteractable interactable)
    {
        // Right hand is no longer hovering on the socket
    }
}

