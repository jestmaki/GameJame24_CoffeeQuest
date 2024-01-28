using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : MonoBehaviour
{
    [SerializeField] Dialogue dialogue;
    private bool answered;
    public void Interact()
    {
        if (!answered)
        {
            StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue));
        }
    }
}
