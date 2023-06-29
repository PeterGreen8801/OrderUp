using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Audio : MonoBehaviour
{
    public AudioSource packageSocketAudio;

    public void playPackageAudio()
    {
        packageSocketAudio.Play();
    }
}
