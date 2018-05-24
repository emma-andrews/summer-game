using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

<<<<<<< .merge_file_a01896
    public List<Item> items = new List<Item>();
    public static Inventory instance;
    public int space = 15;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }

    public bool Add (Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("Not enough room");
            return false;
        }
        items.Add(item);
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
    }
=======
	public GameObject[] inventory = new GameObject[10];
  
   	public void AddItem(GameObject item)
    {
		bool itemAdded = false;

		for (int i = 0; i < inventory.Length;i++)
		{
			if(inventory[i] == null){
				inventory[i] = item;
				Debug.Log(item.name + "was added");
				itemAdded = true;
				break;
			}
		}

		if(!itemAdded){
			Debug.Log("Inventory full, item not added");
		}
       
    }

    
>>>>>>> .merge_file_a08240
}
