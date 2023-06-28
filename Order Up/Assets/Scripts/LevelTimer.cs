using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LevelTimer : MonoBehaviour
{
    [SerializeField]
    public Image fill;
    [SerializeField]
    public TextMeshProUGUI text;

    public int timeLength;

    public int remainingDuration;


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
            text.text = $"{remainingDuration % 60}";
            fill.fillAmount = Mathf.InverseLerp(0, timeLength, remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        EndOfTimer();
    }

    public void EndOfTimer()
    {
        Debug.Log("End of timer");
    }

    public void startTimer()
    {
        countdown(timeLength);
    }

}
