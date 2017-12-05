using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerBG2 : MonoBehaviour {

    public Transform backgroundTransform;
    private Transform cameraTransform;

	// Use this for initialization
	void Start () {
        cameraTransform = Camera.main.transform;
	}

    void Update()
    {
        cameraTransform.position = new Vector3(backgroundTransform.position.x, backgroundTransform.position.y, cameraTransform.position.z);
    }
}
