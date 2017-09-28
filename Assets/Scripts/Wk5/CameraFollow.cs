using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform objectToFollow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(objectToFollow)
            this.transform.position = new Vector3(objectToFollow.position.x, 0, this.transform.position.z);
	}
}
