using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class EnemyController : MonoBehaviour {

    public Boundary bounds;
    private Rigidbody2D rBody;
    private Vector2 moveVel;
    private bool isFlipX;

	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody2D>();
        isFlipX = GetComponent<SpriteRenderer>().flipX;


        if(isFlipX)
            moveVel = new Vector2(-2.0f, 0.0f);
        else
            moveVel = new Vector2(2.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < bounds.xMin)
        {
            moveVel = new Vector2(2.0f, 0.0f);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (transform.position.x > bounds.xMax)
        {
            moveVel = new Vector2(-2.0f, 0.0f);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        rBody.velocity = moveVel;
    }
}
