using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : MonoBehaviour, Interactable
{
    [SerializeField] Dialogue dialogue;
    public void Interact()
    {
        Debug.Log("Talk with NPC");
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue));
    }
}
