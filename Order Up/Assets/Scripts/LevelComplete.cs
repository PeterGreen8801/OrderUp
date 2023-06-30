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

    public XRRayInteractor xRRayInteractor;

    public XRDirectInteractor LeftxRDirectInteractor;
    public XRDirectInteractor RightxRDirectInteractor;


    public LevelTimer levelTimer;

    public int currentPlayerScore = 0;
    public int playerHighScore = 0;

    public Image backgroundImage;
    public Image oneStar;
    public Image twoStar;
    public Image threeStar;

    void Start()
    {
        currentPlayerScore = 0;
    }

    public void freezePlayer()
    {
        dynamicMoveProvider.enabled = false;
        teleportationProvider.enabled = false;
        xRRayInteractor.enabled = false;
        RightxRDirectInteractor.enabled = false;
        LeftxRDirectInteractor.enabled = false;
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
        if (playerRemainingTime < 40 && playerRemainingTime > 20)
        {
            currentPlayerScore = 2;
            Color threeStarColor = threeStar.color;
            threeStarColor.a = 0.1f;
            threeStar.color = threeStarColor;
            PlayerPrefs.SetInt("LevelOneCurrentScore", currentPlayerScore);
        }
        if (playerRemainingTime < 20)
        {
            currentPlayerScore = 1;
            Color twoStarColor = twoStar.color;
            twoStarColor.a = 0.1f;
            twoStar.color = twoStarColor;

            Color threeStarColor = threeStar.color;
            threeStarColor.a = 0.1f;
            threeStar.color = threeStarColor;
            PlayerPrefs.SetInt("LevelOneCurrentScore", currentPlayerScore);
        }

        if (currentPlayerScore == 3)
        {
            playerHighScore = 3;
            PlayerPrefs.SetInt("LevelOneHighScore", playerHighScore);
        }
        if (currentPlayerScore == 2 && PlayerPrefs.GetInt("LevelOneHighScore") < 3)
        {
            playerHighScore = 2;
            PlayerPrefs.SetInt("LevelOneHighScore", playerHighScore);
        }
        if (currentPlayerScore == 1 && PlayerPrefs.GetInt("LevelOneHighScore") < 2)
        {
            playerHighScore = 1;
            PlayerPrefs.SetInt("LevelOneHighScore", playerHighScore);
        }
    }

}
