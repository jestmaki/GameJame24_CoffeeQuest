using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class ChaseAI : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float checkRadius;
    [SerializeField] Dialogue dialogue;
    public bool isFollowing;
    public bool isCollided;
    public GameObject player;
    public PlayerScript playerScript;
    public LayerMask playerLayer;

    private Transform target;
    private Rigidbody2D rigidBody;

    private Animator myAnimator;
    //private Animator anim;
    private Vector2 movement;
    public Vector3 dir;
    //public Vector3 currentDirection;

    private bool isMoving;
    private float dirX;
    private float dirY;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        target = player.transform;
        isFollowing = Physics2D.OverlapCircle(transform.position, checkRadius, playerLayer);
        dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        dir.Normalize();
        movement = dir;

        myAnimator.SetBool("isMoving", isMoving);
        //Debug.Log(dir);
        
    }

    private void FixedUpdate()
    {
        if(isFollowing && !isCollided)
        {
            isMoving = true;
            rigidBody.MovePosition(transform.position + dir * speed * Time.deltaTime);
            //Debug.Log(dir);
        }
        else{
            //Debug.Log("Stopped!");
            isMoving = false;
            rigidBody.velocity = Vector3.zero;

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);
        if (collision.gameObject.name == "ObjPlayer")
        {
            isCollided = true;
            //Debug.Log("Whoopsie!");
            playerScript.canMove = false;
            Interact();
        }
    }

    public void Interact()
    {
        Debug.Log("Talk with NPC");
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue));
    }

    //private void MoveCharacter(Vector3 dir)
    //{
    //    rigidBody.MovePosition(transform.position + dir * speed * Time.deltaTime);
    //    Debug.Log(dir);
    //}
}
