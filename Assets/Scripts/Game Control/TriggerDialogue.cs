using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public bool isActivated;
    [SerializeField] Dialogue dialogue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !isActivated)
        {
            isActivated = true;
            Debug.Log("Triggered!");
            StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue));
        }
    }
}
