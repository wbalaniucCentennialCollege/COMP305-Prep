using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxControl : MonoBehaviour {

    public float parallaxSpeed = 0.0f;

    private Transform mainCamera;
    private float lastCameraX;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main.transform;
        lastCameraX = mainCamera.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        // this.transform.position = mainCamera.transform.position * parallaxSpeed;
        // this.transform.position = new Vector3(mainCamera.position.x, mainCamera.position.y, this.transform.position.z) * parallaxSpeed;

        float deltaX = mainCamera.position.x - lastCameraX;
        transform.position += Vector3.right * (deltaX * parallaxSpeed);

        lastCameraX = mainCamera.position.x;
        
	}
}
