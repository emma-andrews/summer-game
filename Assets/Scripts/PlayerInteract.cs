﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {
    
	public GameObject currentInterObj = null;

	void Update(){
		if(Input.GetButtonDown("Interact") && currentInterObj)
		{
			//Do something with the object
			currentInterObj.SendMessage("DoInteraction");
		}
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Interactable"))
		{
			Debug.Log(collision.name);
			currentInterObj = collision.gameObject;
		}
	}
	private void OnTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("Interactable"))
		{
			if(other.gameObject == currentInterObj)
			{

				currentInterObj = null;
			}
		}
	}

}