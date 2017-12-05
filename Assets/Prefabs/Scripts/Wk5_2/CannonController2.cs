using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CannonConfig2
{
    public float rotationSpeed, launchSpeed;
    public GameObject cannonBall;
    public Transform shotSpawn;
}

public class CannonController2 : MonoBehaviour {

    public CannonConfig2 cannonConfig;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(Vector3.back * cannonConfig.rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(-Vector3.back * cannonConfig.rotationSpeed * Time.deltaTime);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            GameObject ball = Instantiate(cannonConfig.cannonBall, cannonConfig.shotSpawn.position, Quaternion.identity) as GameObject;

            Vector2 forceVec = cannonConfig.shotSpawn.position - this.transform.position;
            forceVec *= cannonConfig.launchSpeed;

            ball.GetComponent<Rigidbody2D>().AddForce(forceVec);
        }
    }
}
