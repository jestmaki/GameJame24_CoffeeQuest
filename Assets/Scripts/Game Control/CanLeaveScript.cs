using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanLeaveScript : MonoBehaviour, Interactable
{
    public GameObject LevelChanger;
    public Level2Changer levelChanger;
    [SerializeField] Dialogue dialogue;

    public void Interact()
    {
        Debug.Log("Level changed");
        levelChanger.canLeave = true;
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue));
    }
}
