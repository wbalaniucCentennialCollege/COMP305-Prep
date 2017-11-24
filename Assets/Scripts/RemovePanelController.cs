using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePanelController : MonoBehaviour {

	// Use this for initialization
	public void RemoveOffScreen()
    {
        this.transform.gameObject.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
