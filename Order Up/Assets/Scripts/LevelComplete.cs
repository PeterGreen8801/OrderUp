using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class LevelComplete : MonoBehaviour
{
    public DynamicMoveProvider dynamicMoveProvider;

    public TeleportationProvider teleportationProvider;

    public LevelTimer levelTimer;

    public int currentPlayerScore = 0;
    public int playerHighScore = 0;

    public Image backgroundImage;
    public Image oneStar;
    public Image twoStar;
    public Image threeStar;

    public void freezePlayer()
    {
        dynamicMoveProvider.enabled = false;
        teleportationProvider.enabled = false;
    }

    public void playerLevelScore()
    {
        int playerRemainingTime = levelTimer.getTime();

        backgroundImage.gameObject.SetActive(true);

        if (playerRemainingTime < 60 && playerRemainingTime > 40)
        {
            currentPlayerScore = 3;
            PlayerPrefs.SetInt("LevelOneCurrentScore", currentPlayerScore);
        }
        else if (playerRemainingTime < 40 && playerRemainingTime > 20)
        {
            currentPlayerScore = 2;
            Color threeStarColor = threeStar.color;
            threeStarColor.a = 0.1f;
            threeStar.color = threeStarColor;
            PlayerPrefs.SetInt("LevelOneCurrentScore", currentPlayerScore);
        }
        else
        {
            currentPlayerScore = 1;
            Color twoStarColor = twoStar.color;
            twoStarColor.a = 0.1f;
            threeStar.color = twoStarColor;
            PlayerPrefs.SetInt("LevelOneCurrentScore", currentPlayerScore);
        }

        if (currentPlayerScore == 3 && playerHighScore < 3)
        {
            playerHighScore = 3;
            PlayerPrefs.SetInt("LevelOneHighScore", playerHighScore);
        }
        if (currentPlayerScore == 2 && playerHighScore < 2)
        {
            playerHighScore = 2;
            PlayerPrefs.SetInt("LevelOneHighScore", playerHighScore);
        }
        if (currentPlayerScore == 1)
        {
            playerHighScore = 1;
            PlayerPrefs.SetInt("LevelOneHighScore", playerHighScore);
        }
    }

}
