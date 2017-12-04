using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCameraFollowTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Cannon")
        {
            Camera.main.GetComponent<CameraFollow>().objectToFollow = other.transform;
        }
    } 
}
