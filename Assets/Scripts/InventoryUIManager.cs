using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIManager : MonoBehaviour {

    private GameObject[] slots;

	// Use this for initialization
	void Start () {
        slots = new GameObject[this.transform.childCount];

        for(int i = 0; i < this.transform.childCount; i++)
        {
            slots[i] = this.transform.GetChild(i).gameObject;
        }
	}
	
	public void UpdateUI(Item item)
    {
        foreach(GameObject o in slots)
        {
            o.GetComponent<SlotManager>().AddItem(item);
        }
    }
}
