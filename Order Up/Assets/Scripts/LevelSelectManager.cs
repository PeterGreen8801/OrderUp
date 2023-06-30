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
    public XRKnob level3Knob;

    public GameObject Level1Area;
    public GameObject Level2Area;
    public GameObject Level3Area;

    public GameObject LevelOneScore;
    public Image LevelOneTwoStar;
    public Image LevelOneThreeStar;

    public GameObject LevelTwoScore;
    public Image LevelTwoTwoStar;
    public Image LevelTwoThreeStar;

    // Start is called before the first frame update
    void Start()
    {
        updateUnlockedLevels();
    }

    public void updateUnlockedLevels()
    {
        //Player Unlocked Level 2, Updates Highscore for Level 1
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

        if (PlayerPrefs.GetInt("CurrentLevelUnlocked") == 3)
        {
            //Will still show Level 1 Score above door
            LevelOneScore.gameObject.SetActive(true);

            //WIll keep Level 2 door unlocked
            level2Knob.enabled = true;
            Level2Area.SetActive(true);

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



            //Unlocks level 3, updates highscore for level 2
            level3Knob.enabled = true;
            Level3Area.SetActive(true);

            LevelTwoScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelTwoHighScore") == 2)
            {
                Color LevelTwoThreeStarColor = LevelTwoThreeStar.color;
                LevelTwoThreeStarColor.a = 0.1f;
                LevelTwoThreeStar.color = LevelTwoThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelTwoHighScore") == 1)
            {
                Color LevelTwoThreeStarColor = LevelTwoThreeStar.color;
                LevelTwoThreeStarColor.a = 0.1f;
                LevelTwoThreeStar.color = LevelTwoThreeStarColor;

                Color LevelTwoTwoStarColor = LevelTwoTwoStar.color;
                LevelTwoTwoStarColor.a = 0.1f;
                LevelTwoTwoStar.color = LevelTwoTwoStarColor;
            }
        }
    }
}
