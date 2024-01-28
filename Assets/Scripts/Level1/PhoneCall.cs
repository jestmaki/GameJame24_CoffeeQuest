using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : MonoBehaviour, Interactable
{
    [SerializeField] Dialogue dialogue;
    public void Interact()
    {
        Debug.Log("Something is working");
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue));
    }
}
