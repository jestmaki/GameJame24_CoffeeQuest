using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState{ FreeRoam, Dialogue}

public class GameController : MonoBehaviour
{
    [SerializeField] PlayerScript playerController;

    GameState state;

    private void Update()
    {
        if (state == GameState.FreeRoam)
        {
            playerController.HandleUpdate();
        }

        else if (state == GameState.Dialogue)
        {

        }
    }

}
