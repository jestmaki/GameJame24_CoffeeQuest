using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [SerializeField] [TextArea] List<string> lines;

    public List<string> Lines
    {
        get {return lines;}
    }
}
