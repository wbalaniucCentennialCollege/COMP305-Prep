using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour {

    public float shotSpeed = 10.0f;
    public float damage = 20.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * shotSpeed;
	}
}
