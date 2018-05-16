using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        playerMoving = false;

		if (Input.GetAxis("Horizontal") > 0.5f || Input.GetAxis("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxis("Horizontal"), 0f);
        }

        if (Input.GetAxis("Vertical") > 0.5f || Input.GetAxis("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0f));
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxis("Vertical"));
        }

        anim.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxis("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }
}
