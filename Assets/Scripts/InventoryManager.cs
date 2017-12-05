using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    private List<Item> items;

    void Start()
    {
        items = new List<Item>();
    }
	
    public void addItem(Item it)
    {
        items.Add(it);

        // Update our Inventory UI here
        GameObject inventoryUI = GameObject.Find("SlotPanel");
        inventoryUI.GetComponent<InventoryUIManager>().UpdateUI(it);
    }

    public void PrintList()
    {
        foreach(Item i in items)
        {
            Debug.Log(i.itemName);
        }
    }

}
