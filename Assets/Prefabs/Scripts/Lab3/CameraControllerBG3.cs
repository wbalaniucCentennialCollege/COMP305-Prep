using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerBG3 : MonoBehaviour {

    public float zoomSpeed = 0.05f;
    public Transform playerTransform;
    private Transform cameraTransform;

	// Use this for initialization
	void Awake () {
        cameraTransform = Camera.main.transform;


    }
	
	// Update is called once per frame
	void Update () {
        cameraTransform.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, cameraTransform.position.z);

        if(playerTransform.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            Camera.main.orthographicSize -= zoomSpeed;
        }

        if(playerTransform.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            Camera.main.orthographicSize += zoomSpeed;
        }


        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 1.5f, 5.0f);
    }
}
