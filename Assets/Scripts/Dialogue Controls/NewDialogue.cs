using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

[System.Serializable]
public class NewDialogue : MonoBehaviour
{
    //[SerializeField] List<string> lines;
    [SerializeField] private TextMeshProUGUI speakerText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] Image portraitImage;

    [SerializeField] private string[] speaker;
    [SerializeField] [TextArea] private string [] dialogueWords;
    [SerializeField] private Sprite [] portrait;

    //public List<string> Lines
    //{
     //   get {return lines;}
    //}
}
