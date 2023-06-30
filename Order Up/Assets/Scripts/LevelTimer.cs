using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using Unity.XR;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using UnityEngine.XR.Interaction.Toolkit;
public class LevelTimer : MonoBehaviour
{
    [SerializeField]
    public Image fill;
    [SerializeField]
    public TextMeshProUGUI text;

    public DynamicMoveProvider dynamicMoveProvider;

    public TeleportationProvider teleportationProvider;

    public XRRayInteractor xRRayInteractor;

    public XRDirectInteractor LeftxRDirectInteractor;
    public XRDirectInteractor RightxRDirectInteractor;

    public Image backgroundImage;

    public AudioSource countdownAudioSource;

    public AudioSource secondsCountdown;

    public AudioClip timeConfirm;

    public AudioClip secondCount;

    public int timeLength;

    public int remainingDuration;

    public bool paused = false;


    private void Start()
    {
        //countdown(timeLength);
    }

    private void countdown(int seconds)
    {
        remainingDuration = seconds;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            if (paused == false)
            {
                if (remainingDuration == 60)
                {
                    text.text = $"60";
                }
                else
                {
                    text.text = $"{remainingDuration % 60}";
                }
                fill.fillAmount = Mathf.InverseLerp(0, timeLength, remainingDuration);
                if (remainingDuration != 40 || remainingDuration != 20)
                {
                    secondsCountdown.PlayOneShot(secondCount);
                }
                if (remainingDuration == 40)
                {
                    countdownAudioSource.PlayOneShot(timeConfirm);
                }
                if (remainingDuration == 20)
                {
                    countdownAudioSource.PlayOneShot(timeConfirm);
                }
                if (remainingDuration < 6)
                {
                    countdownAudioSource.Play();
                }
                remainingDuration--;
                yield return new WaitForSeconds(1f);
            }
            yield return null;
        }
        EndOfTimer();
    }

    public void pauseTimer()
    {
        paused = true;
    }


    public void EndOfTimer()
    {
        //Debug.Log("End of timer");
        //Here will freeze player, pop up ui
        dynamicMoveProvider.enabled = false;
        teleportationProvider.enabled = false;
        xRRayInteractor.enabled = false;
        RightxRDirectInteractor.enabled = false;
        LeftxRDirectInteractor.enabled = false;

        backgroundImage.gameObject.SetActive(true);
    }

    public void startTimer()
    {
        countdown(timeLength);
    }

    public int getTime()
    {
        return remainingDuration;
    }

}
