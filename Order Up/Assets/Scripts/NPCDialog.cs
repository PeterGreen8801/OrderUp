using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialog : MonoBehaviour
{
    public Image npc1dialog;

    public Image npc7dialog;

    public Image npc2dialogfirst;
    public Image npc2dialog;
    public Image npc3dialog;
    public Image npc4dialog;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC1"))
        {
            npc1dialog.gameObject.SetActive(true);
        }
        if (other.CompareTag("NPC2") && PlayerPrefs.GetInt("LevelOneHighScore") < 1)
        {
            npc2dialogfirst.gameObject.SetActive(true);
        }
        if (other.CompareTag("NPC2") && PlayerPrefs.GetInt("LevelOneHighScore") > 0)
        {
            npc2dialog.gameObject.SetActive(true);
        }
        if (other.CompareTag("NPC3"))
        {
            npc3dialog.gameObject.SetActive(true);
        }
        if (other.CompareTag("NPC4"))
        {
            npc4dialog.gameObject.SetActive(true);
        }
        if (other.CompareTag("NPC7"))
        {
            npc7dialog.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC1"))
        {
            npc1dialog.gameObject.SetActive(false);
        }
        if (other.CompareTag("NPC2") && PlayerPrefs.GetInt("LevelOneHighScore") < 1)
        {
            npc2dialogfirst.gameObject.SetActive(false);
        }
        if (other.CompareTag("NPC2") && PlayerPrefs.GetInt("LevelOneHighScore") > 0)
        {
            npc2dialog.gameObject.SetActive(false);
        }
        if (other.CompareTag("NPC3"))
        {
            npc3dialog.gameObject.SetActive(false);
        }
        if (other.CompareTag("NPC4"))
        {
            npc4dialog.gameObject.SetActive(false);
        }
        if (other.CompareTag("NPC7"))
        {
            npc7dialog.gameObject.SetActive(false);
        }
    }

}
