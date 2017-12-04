using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    private List<GameObject> items;

    void Start()
    {
        items = new List<GameObject>();
    }
	
    public void addItem(GameObject o)
    {
        items.Add(o);
        Debug.Log("Added: " + o.name);
        Debug.Log("Items collects: " + items.Count);
    }
}
