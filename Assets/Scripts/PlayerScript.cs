using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Movement controls
    public float moveSpeed;

    private Vector3 moveDir;

    private Rigidbody2D playerRB;

    private Animator animator;

    public LayerMask interactableLayer;

    //private bool isMoving;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    public void HandleUpdate()
    {
        moveDir = Vector2.zero;
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");

        if(moveDir != Vector3.zero)
        {
            MoveCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Z)) Interact();
                
    }

    void MoveCharacter()
    {
        playerRB.MovePosition (transform.position + moveDir * moveSpeed * Time.deltaTime);
    }

    void Interact()
    {
        var facingDir = new Vector3(moveDir.x, moveDir.y);
        var interactPos = transform.position + facingDir;
        //Debug.DrawLine(transform.position, interactPos, Color.red, 1f);

        var collider = Physics2D.OverlapCircle(interactPos, 0.2f, interactableLayer);
        if (collider != null)
        {
            Debug.Log("there is an NPC here");
            collider.GetComponent<Interactable>()?.Interact();
        }
    }


}
