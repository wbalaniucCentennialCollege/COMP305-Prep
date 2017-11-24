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
            Destroy(this.gameObject);
        }

        slider.value = currentHealth;

        Debug.Log(currentHealth);
	}

    public void Hit(float hitValue)
    {
        currentHealth -= hitValue;
    }
}
