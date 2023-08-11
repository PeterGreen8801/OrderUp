using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR;

public class LeftOrRightHapticHandProvider : MonoBehaviour
{
    public XRDirectInteractor leftDirectInteractor;
    public XRDirectInteractor rightDirectInteractor;

    public float hapticIntensity = 0.5f;
    public float hapticDuration = 0.25f;


    // Start a haptic impulse with the default intensity and duration
    public void LeftOrRightStandardHaptics()
    {
        if (leftDirectInteractor.hasSelection)
        {
            leftDirectInteractor.SendHapticImpulse(hapticIntensity, hapticDuration);

        }
        if (rightDirectInteractor.hasSelection)
        {
            rightDirectInteractor.SendHapticImpulse(hapticIntensity, hapticDuration);
        }
    }

    // Change the haptic duration to the provided value
    public void ChangeHapticDuration(float modifiedDuration)
    {
        hapticDuration = modifiedDuration;
    }

    // Change the haptic intensity to the provided value
    public void ChangeHapticIntensity(float modifiedIntensity)
    {
        hapticIntensity = modifiedIntensity;
    }
}
