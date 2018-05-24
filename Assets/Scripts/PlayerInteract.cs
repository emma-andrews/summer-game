using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public GameObject currentInterObj = null;
	public InteractionObject currentInterObjScript = null;
    public Inventory inventory;

    void Update()
    {
        if (Input.GetButtonDown("Interact") && currentInterObj)
        {
            //Do something with the object
			if (currentInterObjScript.inventory)
            {
                currentInterObj.SendMessage("DoInteraction");
				inventory.AddItem(currentInterObj);
                
				//if theyve been added but havent been removed, removes them
				if(currentInterObj&&currentInterObjScript){
					currentInterObj = null;
					currentInterObjScript = null;
				}
            }
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            Debug.Log(collision.name);
            currentInterObj = collision.gameObject;
			currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            if (other.gameObject == currentInterObj)
            {
				currentInterObjScript = null;
                currentInterObj = null;
            }
        }
    }

}
