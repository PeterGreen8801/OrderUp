using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR;

public class HapticImpulse : MonoBehaviour
{

    //Deprecated in a way, traded for LeftOrRightHapticHandProvider script

    [SerializeField]
    XRBaseControllerInteractor interactor;

    CheckGrabStatus checkGrabStatus;

    public float hapticIntensity = 0.5f;
    public float hapticDuration = 0.25f;


    // Start a haptic impulse with the specified intensity and default duration
    public void HapticImpulseIntensity(float intensity)
    {
        if (interactor != null)
        {
            //Debug.Log("Send the Haptic Impulse...");
            interactor.SendHapticImpulse(intensity, hapticDuration);
        }
    }

    // Start a haptic impulse with the default intensity and the specified duration
    public void HapticImpulseDuration(float duration)
    {
        if (interactor != null)
        {
            //Debug.Log("Send the Haptic Impulse...");
            interactor.SendHapticImpulse(hapticIntensity, duration);
        }
    }

    // Start a haptic impulse with the default intensity and duration
    public void DefaultHapticImpulse()
    {
        if (interactor != null)
        {
            interactor.SendHapticImpulse(hapticIntensity, hapticDuration);
        }
    }

    // Start a basic haptic impulse with predefined intensity and duration
    public void BasictHapticImpulse()
    {
        if (interactor != null)
        {
            interactor.SendHapticImpulse(0.5f, 0.25f);
        }
    }

    // Change the haptic intensity to the provided value
    public void ChangeHapticIntensity(float modifiedIntensity)
    {
        hapticIntensity = modifiedIntensity;
    }

    // Change the haptic duration to the provided value
    public void ChangeHapticDuration(float modifiedDuration)
    {
        hapticDuration = modifiedDuration;
    }

    public void leftHandImpulse()
    {
        if (checkGrabStatus.checkLeftGrab() == true)
        {
            BasictHapticImpulse();
        }
    }

    public void rightHandImpulse()
    {
        if (checkGrabStatus.checkRightGrab() == true)
        {
            BasictHapticImpulse();
        }
    }

}
