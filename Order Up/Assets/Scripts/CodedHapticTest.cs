using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class CodedHapticTest : MonoBehaviour
{
    XRBaseInteractable interactable;
    XRBaseControllerInteractor interactor;

    public float hapticIntensity = 0.5f;
    public float hapticDuration = 0.25f;
 
    void Start()
    {
        if (TryGetComponent<XRBaseInteractable>(out interactable))
        {
            interactable.hoverEntered.AddListener(StartHover);
        }
        if (TryGetComponent<XRBaseControllerInteractor>(out interactor))
        {
            interactor.hoverEntered.AddListener(StartHover);
        }
    }
 
    private void OnDisable()
    {
        if (interactable != null)
            interactable.hoverEntered.RemoveListener(StartHover);
 
        if (interactor != null)
            interactor.hoverEntered.RemoveListener(StartHover);
    }
 
    public void StartHover(HoverEnterEventArgs args)
    {
        var interactor = args.interactorObject as XRBaseControllerInteractor;
        if (interactor != null)
        {
            Debug.Log("Sending Haptic Impulse...");
            interactor.SendHapticImpulse(hapticIntensity, hapticDuration);
        }
    }
}
