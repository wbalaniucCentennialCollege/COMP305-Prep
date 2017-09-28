using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    public float launchSpeed = 1000.0f;
    public GameObject cannonBall;
    public Transform shotSpawn;

    private CameraFollow cameraFollow;

	// Use this for initialization
	void Start () {
        cameraFollow = Camera.main.GetComponent<CameraFollow>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyUp(KeyCode.Space) )
        {
            GameObject ball = Instantiate(cannonBall, shotSpawn.position, Quaternion.identity) as GameObject;
            Vector2 forceVec = shotSpawn.transform.position - this.transform.position;
            forceVec *= launchSpeed;
            ball.GetComponent<Rigidbody2D>().AddForce(forceVec);
        }
	}
}
