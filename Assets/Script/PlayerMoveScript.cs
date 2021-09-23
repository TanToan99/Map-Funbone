using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float moveSpeed = 2000f;
    private Animator anim;
    private bool playerMoving;
    private Rigidbody2D body;

    // Use this for initialization
    void Start ()  {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()  {
        playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed, 0f));
            playerMoving = true;
        }
    
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector2(0f, Input.GetAxisRaw("Vertical") * Time.deltaTime  * moveSpeed));
            playerMoving = true;
        }
        anim.SetBool("Walkleft", playerMoving);

    }
}
