using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
	}
}
