using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    public float maxHealth = 100;
    public Slider slider;

    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;    
    }


    // Update is called once per frame
    void Update () {
		if(currentHealth <= 0.0f)
        {
            this.transform.parent.GetComponent<EnemyManager>().RemoveEnemy(this.gameObject);
            Destroy(this.gameObject);
        }

        slider.value = currentHealth;
	}

    public void Hit(float hitValue)
    {
        currentHealth -= hitValue;
    }
}
