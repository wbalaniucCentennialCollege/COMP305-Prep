using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour {

    public bool bg1, bg2, bg3;

	void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision");

        if (bg1)
            Camera.main.GetComponent<CameraControllerBG1>().enabled = true;
        else
            Camera.main.GetComponent<CameraControllerBG1>().enabled = false;

        if (bg2)
            Camera.main.GetComponent<CameraControllerBG2>().enabled = true;
        else
            Camera.main.GetComponent<CameraControllerBG2>().enabled = false;

        if (bg3)
            Camera.main.GetComponent<CameraControllerBG3>().enabled = true;
        else
            Camera.main.GetComponent<CameraControllerBG3>().enabled = false;

    }
}
