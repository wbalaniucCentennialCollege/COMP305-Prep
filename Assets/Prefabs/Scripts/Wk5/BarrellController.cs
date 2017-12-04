using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrellController : MonoBehaviour {

    public GameObject explosion;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Cannon")
        {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
