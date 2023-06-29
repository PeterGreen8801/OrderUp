using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerData : MonoBehaviour
{
    public int newestLevelUnlocked = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void updateLevelUnlocked(int levelToUnlock)
    {
        PlayerPrefs.SetInt("CurrentLevelUnlocked", levelToUnlock);
    }

    //Takes currentLevel from editor and makes sure that newestLevelUnlocked is only updated if that is the player's currentNewestLevel
    //Ensures that a player can't replay a level and unlock a new one.
    public void unlockNextLevel(int currentLevel)
    {
        if (newestLevelUnlocked <= currentLevel)
        {
            newestLevelUnlocked = newestLevelUnlocked + 1;
            PlayerPrefs.SetInt("CurrentLevelUnlocked", newestLevelUnlocked);
        }
    }
}
