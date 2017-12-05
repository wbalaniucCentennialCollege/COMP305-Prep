using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIManager : MonoBehaviour {

    private GameObject[] slots;

	// Use this for initialization
	void Start () {
        slots = new GameObject[this.transform.childCount];
	}
	
	public void UpdateUI()
    {
        Debug.Log("HELLO");
    }
}
