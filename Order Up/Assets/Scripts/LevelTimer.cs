using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class LevelTimer : MonoBehaviour
{
    [SerializeField]
    public Image fill;
    [SerializeField]
    public TextMeshProUGUI text;

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
                text.text = $"{remainingDuration % 59}";
                fill.fillAmount = Mathf.InverseLerp(0, timeLength, remainingDuration);
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
        Debug.Log("End of timer");
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
