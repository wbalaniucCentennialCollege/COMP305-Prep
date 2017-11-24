using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnBounds
{
    public float xMin, xMax, yMin, yMax;
}

public class EnemyManager : MonoBehaviour {

    public int numberOfEnemies = 5;
    public SpawnBounds bounds;
    public GameObject enemy;
    public EnemyTrackerUIController enemyUI;

    private List<GameObject> enemies;

	// Use this for initialization
	void Start () {
        enemies = new List<GameObject>();

        SpawnEnemies();
	}

    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            GameObject o = Instantiate(enemy, new Vector3(Random.Range(bounds.xMin, bounds.xMax), Random.Range(bounds.yMin, bounds.yMax), 0.0f), Quaternion.identity) as GameObject;
            o.transform.parent = this.transform;
            o.GetComponent<SpriteRenderer>().flipX = (Random.value > 0.5f);
            enemies.Add(o);
        }

        enemyUI.SpawnImages(numberOfEnemies); 
    }

    public void RemoveEnemy(GameObject o)
    {
        enemies.Remove(o);
        enemyUI.RemoveImage();
    }
}
