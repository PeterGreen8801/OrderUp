using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.UI;
using TMPro;
public class LevelSelectManager : MonoBehaviour
{

    public XRKnob level1Knob;
    public XRKnob level2Knob;

    public GameObject Level1Area;
    public GameObject Level2Area;

    public GameObject LevelOneScore;
    public Image LevelOneTwoStar;
    public Image LevelOneThreeStar;

    // Start is called before the first frame update
    void Start()
    {
        updateUnlockedLevels();
    }

    public void updateUnlockedLevels()
    {
        //Player Unlocked Level 2
        if (PlayerPrefs.GetInt("CurrentLevelUnlocked") == 2)
        {
            level2Knob.enabled = true;
            Level2Area.SetActive(true);

            LevelOneScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelOneHighScore") == 2)
            {
                Color LevelOneThreeStarColor = LevelOneThreeStar.color;
                LevelOneThreeStarColor.a = 0.1f;
                LevelOneThreeStar.color = LevelOneThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelOneHighScore") == 1)
            {
                Color LevelOneThreeStarColor = LevelOneThreeStar.color;
                LevelOneThreeStarColor.a = 0.1f;
                LevelOneThreeStar.color = LevelOneThreeStarColor;

                Color LevelOneTwoStarColor = LevelOneTwoStar.color;
                LevelOneTwoStarColor.a = 0.1f;
                LevelOneTwoStar.color = LevelOneTwoStarColor;
            }
        }
    }
}
