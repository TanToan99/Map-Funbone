using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMoveCamera : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public float moveSpeed = 400f;
    private int playerMoving;
    PhotonView view;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine){
            playerMoving = 0;
            rb.velocity = Vector2.zero;
            
            
            if (Input.GetKey(KeyCode.UpArrow)) {
                rb.velocity = new Vector2(0, moveSpeed * Time.deltaTime);
                playerMoving = 1;
            }
            if (Input.GetKey(KeyCode.LeftArrow)) {
                rb.velocity = new Vector2(-moveSpeed*Time.deltaTime,0);
                playerMoving = 2;
            }
            if(Input.GetKey(KeyCode.DownArrow)) {
                rb.velocity = new Vector2(0, -moveSpeed * Time.deltaTime);
                playerMoving = 3;
            }
            if (Input.GetKey(KeyCode.RightArrow)) {
                rb.velocity = new Vector2(moveSpeed*Time.deltaTime, 0);
                playerMoving = 4;
            }
            anim.SetInteger("Walk", playerMoving);
        }
        
    }
}
