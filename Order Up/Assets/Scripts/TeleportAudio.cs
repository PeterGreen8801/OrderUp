using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAudio : MonoBehaviour
{

    public AudioSource teleportAudioSource;
    public AudioClip teleportClip;

    public float timeWindow = 2f; // Time window in seconds
    public int maxPitchIncrements = 8; // Maximum pitch increments

    private float lastTeleportTime;
    private int pitchIncrements;

    void Awake()
    {

    }

    public void PlayTeleportSound()
    {
        float currentTime = Time.time;

        // Check if within the time window
        if (currentTime - lastTeleportTime <= timeWindow)
        {
            // Increment the pitch
            pitchIncrements++;
            if (pitchIncrements <= maxPitchIncrements)
            {
                teleportAudioSource.pitch += 0.1f; // Increase the pitch by 0.1
            }
        }
        else
        {
            // Reset the pitch and increments
            teleportAudioSource.pitch = 1f;
            pitchIncrements = 0;
        }

        // Play the teleport sound
        teleportAudioSource.PlayOneShot(teleportClip);

        // Update the last teleport time
        lastTeleportTime = currentTime;
    }


}
