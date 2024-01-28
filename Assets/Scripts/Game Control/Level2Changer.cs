using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Changer : MonoBehaviour
{
    public int sceneBuildIndex;
    public bool canLeave;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(canLeave);
            if (canLeave == true)
            {
                print("Switching scene to " + sceneBuildIndex);
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
            else
            {
                Debug.Log("I need something");
            }
        }

    }
}
