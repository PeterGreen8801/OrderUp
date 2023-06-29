using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;
public class LevelSelectManager : MonoBehaviour
{

    public XRKnob level1Knob;
    public XRKnob level2Knob;

    public GameObject Level1Area;
    public GameObject Level2Area;

    // Start is called before the first frame update
    void Start()
    {
        updateUnlockedLevels();
    }

    public void updateUnlockedLevels()
    {
        if (PlayerPrefs.GetInt("CurrentLevelUnlocked") == 2)
        {
            level2Knob.enabled = true;
            Level2Area.SetActive(true);
        }
    }
}
