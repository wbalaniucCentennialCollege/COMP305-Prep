using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CannonConfig
{
    public float minAngle, maxAngle, rotationSpeed, launchSpeed;
}

public class CannonController : MonoBehaviour
{
    public CannonConfig cannonConfig;
    public GameObject cannonBall;
    public Transform shotSpawn;

    private CameraFollow cameraFollow;

    // Use this for initialization
    void Start() {
        cameraFollow = Camera.main.GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            // this.transform.Rotate(this.transform.rotation.eulerAngles.x, this.transform.rotation.eulerAngles.y, this.transform.rotation.eulerAngles.z + 0.05f, Space.World);
            this.transform.Rotate(Vector3.back * cannonConfig.rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(-Vector3.back * cannonConfig.rotationSpeed * Time.deltaTime);
        }


		if(Input.GetKeyUp(KeyCode.Space) )
        {
            GameObject ball = Instantiate(cannonBall, shotSpawn.position, Quaternion.identity) as GameObject;
            Vector2 forceVec = shotSpawn.transform.position - this.transform.position;
            forceVec *= cannonConfig.launchSpeed;
            ball.GetComponent<Rigidbody2D>().AddForce(forceVec);
        }
	}
}
