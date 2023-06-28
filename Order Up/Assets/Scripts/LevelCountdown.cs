using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
public class LevelCountdown : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI text;

    public int timeLength;

    public int remainingDuration;

    public LevelTimer levelTimer;

    public DynamicMoveProvider dynamicMoveProvider;

    public TeleportationProvider teleportationProvider;

    private void Start()
    {
        countdown(timeLength);
        dynamicMoveProvider.enabled = false;
        teleportationProvider.enabled = false;
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
            int counter = remainingDuration;
            if (counter > 0)
            {
                text.text = $"{remainingDuration % 60}";
                remainingDuration--;
            }
            else
            {
                text.text = "Go";
                remainingDuration--;
            }

            yield return new WaitForSeconds(1f);
        }
        EndOfTimer();
    }
    public void EndOfTimer()
    {
        Debug.Log("End of timer");
        text.gameObject.SetActive(false);
        levelTimer.startTimer();
        dynamicMoveProvider.enabled = true;
        teleportationProvider.enabled = true;
    }
}
