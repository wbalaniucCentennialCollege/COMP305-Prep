using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerBG1 : MonoBehaviour {

    public Transform playerTransform;
    private Transform cameraTransform;

	// Use this for initialization
	void Awake () {
        cameraTransform = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        cameraTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, cameraTransform.position.z);
	}
}
