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
    public XRKnob level4Knob;
    public XRKnob level5Knob;

    public GameObject ThankYouScreen;

    public GameObject Level1Area;
    public GameObject Level2Area;
    public GameObject Level3Area;
    public GameObject Level4Area;
    public GameObject level5Area;

    public GameObject LevelOneScore;
    public Image LevelOneTwoStar;
    public Image LevelOneThreeStar;

    public GameObject LevelTwoScore;
    public Image LevelTwoTwoStar;
    public Image LevelTwoThreeStar;

    public GameObject LevelThreeScore;
    public Image LevelThreeTwoStar;
    public Image LevelThreeThreeStar;

    public GameObject LevelFourScore;
    public Image LevelFourTwoStar;
    public Image LevelFourThreeStar;

    public GameObject LevelFiveScore;
    public Image LevelFiveTwoStar;
    public Image LevelFiveThreeStar;

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

        if (PlayerPrefs.GetInt("CurrentLevelUnlocked") == 4)
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

            //Unlocks level 4, updates highscore for level 3
            level4Knob.enabled = true;
            Level4Area.SetActive(true);

            LevelThreeScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelThreeHighScore") == 2)
            {
                Color LevelThreeThreeStarColor = LevelThreeThreeStar.color;
                LevelThreeThreeStarColor.a = 0.1f;
                LevelThreeThreeStar.color = LevelThreeThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelThreeHighScore") == 1)
            {
                Color LevelThreeThreeStarColor = LevelThreeThreeStar.color;
                LevelThreeThreeStarColor.a = 0.1f;
                LevelThreeThreeStar.color = LevelThreeThreeStarColor;

                Color LevelThreeTwoStarColor = LevelThreeTwoStar.color;
                LevelThreeTwoStarColor.a = 0.1f;
                LevelThreeTwoStar.color = LevelThreeTwoStarColor;
            }
        }

        if (PlayerPrefs.GetInt("CurrentLevelUnlocked") == 5)
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

            //Unlocks level 4, updates highscore for level 3
            level4Knob.enabled = true;
            Level4Area.SetActive(true);

            LevelThreeScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelThreeHighScore") == 2)
            {
                Color LevelThreeThreeStarColor = LevelThreeThreeStar.color;
                LevelThreeThreeStarColor.a = 0.1f;
                LevelThreeThreeStar.color = LevelThreeThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelThreeHighScore") == 1)
            {
                Color LevelThreeThreeStarColor = LevelThreeThreeStar.color;
                LevelThreeThreeStarColor.a = 0.1f;
                LevelThreeThreeStar.color = LevelThreeThreeStarColor;

                Color LevelThreeTwoStarColor = LevelThreeTwoStar.color;
                LevelThreeTwoStarColor.a = 0.1f;
                LevelThreeTwoStar.color = LevelThreeTwoStarColor;
            }

            level5Knob.enabled = true;
            level5Area.SetActive(true);

            LevelFourScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelFourHighScore") == 2)
            {
                Color LevelFourThreeStarColor = LevelFourThreeStar.color;
                LevelFourThreeStarColor.a = 0.1f;
                LevelFourThreeStar.color = LevelFourThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelFourHighScore") == 1)
            {
                Color LevelFourThreeStarColor = LevelFourThreeStar.color;
                LevelFourThreeStarColor.a = 0.1f;
                LevelFourThreeStar.color = LevelFourThreeStarColor;

                Color LevelFourTwoStarColor = LevelFourTwoStar.color;
                LevelFourTwoStarColor.a = 0.1f;
                LevelFourTwoStar.color = LevelFourTwoStarColor;
            }
        }

        if (PlayerPrefs.GetInt("CurrentLevelUnlocked") == 6)
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

            //Unlocks level 4, updates highscore for level 3
            level4Knob.enabled = true;
            Level4Area.SetActive(true);

            LevelThreeScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelThreeHighScore") == 2)
            {
                Color LevelThreeThreeStarColor = LevelThreeThreeStar.color;
                LevelThreeThreeStarColor.a = 0.1f;
                LevelThreeThreeStar.color = LevelThreeThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelThreeHighScore") == 1)
            {
                Color LevelThreeThreeStarColor = LevelThreeThreeStar.color;
                LevelThreeThreeStarColor.a = 0.1f;
                LevelThreeThreeStar.color = LevelThreeThreeStarColor;

                Color LevelThreeTwoStarColor = LevelThreeTwoStar.color;
                LevelThreeTwoStarColor.a = 0.1f;
                LevelThreeTwoStar.color = LevelThreeTwoStarColor;
            }

            level5Knob.enabled = true;
            level5Area.SetActive(true);

            LevelFourScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelFourHighScore") == 2)
            {
                Color LevelFourThreeStarColor = LevelFourThreeStar.color;
                LevelFourThreeStarColor.a = 0.1f;
                LevelFourThreeStar.color = LevelFourThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelFourHighScore") == 1)
            {
                Color LevelFourThreeStarColor = LevelFourThreeStar.color;
                LevelFourThreeStarColor.a = 0.1f;
                LevelFourThreeStar.color = LevelFourThreeStarColor;

                Color LevelFourTwoStarColor = LevelFourTwoStar.color;
                LevelFourTwoStarColor.a = 0.1f;
                LevelFourTwoStar.color = LevelFourTwoStarColor;
            }

            ThankYouScreen.gameObject.SetActive(true);

            LevelFiveScore.gameObject.SetActive(true);

            if (PlayerPrefs.GetInt("LevelFiveHighScore") == 2)
            {
                Color LevelFiveThreeStarColor = LevelFiveThreeStar.color;
                LevelFiveThreeStarColor.a = 0.1f;
                LevelFiveThreeStar.color = LevelFiveThreeStarColor;
            }
            if (PlayerPrefs.GetInt("LevelFiveHighScore") == 1)
            {
                Color LevelFiveThreeStarColor = LevelFiveThreeStar.color;
                LevelFiveThreeStarColor.a = 0.1f;
                LevelFiveThreeStar.color = LevelFiveThreeStarColor;

                Color LevelFiveTwoStarColor = LevelFiveTwoStar.color;
                LevelFiveTwoStarColor.a = 0.1f;
                LevelFiveTwoStar.color = LevelFiveTwoStarColor;
            }
        }
    }
}
