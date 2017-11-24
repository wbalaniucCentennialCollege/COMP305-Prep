using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderController : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Shot")
        {
            Destroy(other.gameObject);
            GetComponent<EnemyHealth>().Hit(other.GetComponent<ShotController>().damage);
        }
    }
}
