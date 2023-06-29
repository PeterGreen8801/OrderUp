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
        PlayerPrefs.SetInt("LevelOneHighScore", 1);
    }
}
