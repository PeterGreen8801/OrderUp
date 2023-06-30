using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookshotAudio : MonoBehaviour
{
    public AudioSource hookshotAudioSource;
    public AudioClip hookshotClip;

    public float timeWindow = 2f; // Time window in seconds
    public int maxPitchIncrements = 8; // Maximum pitch increments

    private float lastHookshotTime;
    private int pitchIncrements;

    void Awake()
    {

    }

    public void PlayHookshotSound()
    {
        float currentTime = Time.time;

        // Check if within the time window
        if (currentTime - lastHookshotTime <= timeWindow)
        {
            // Increment the pitch
            pitchIncrements++;
            if (pitchIncrements <= maxPitchIncrements)
            {
                hookshotAudioSource.pitch += 0.1f; // Increase the pitch by 0.1
            }
        }
        else
        {
            // Reset the pitch and increments
            hookshotAudioSource.pitch = 1f;
            pitchIncrements = 0;
        }

        // Play the teleport sound
        hookshotAudioSource.PlayOneShot(hookshotClip);

        // Update the last teleport time
        lastHookshotTime = currentTime;
    }
}
