using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    //private Animator anim;

	// Use this for initialization
	void Start () {
        //anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Horizontal") > 0.5f || Input.GetAxis("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetAxis("Vertical") > 0.5f || Input.GetAxis("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }

        //anim.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        //anim.SetFloat("MoveY", Input.GetAxis("Vertical"));
    }
}
