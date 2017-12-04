using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnBoundary
{
    public float minX, maxX;
}

public class ItemSpawner : MonoBehaviour {

    public List<GameObject> items;
    public float spawnTime = 1.0f;
    public SpawnBoundary boundary;

	// Use this for initialization
	void Start () {
        // items = new List<GameObject>();

        Invoke("SpawnItem", Random.Range(0.0f, spawnTime));
	}
	
	private void SpawnItem()
    {
        Instantiate(
            items[Random.Range(0, items.Count)],
            new Vector2(Random.Range(boundary.minX, boundary.maxX), this.transform.position.y),
            Quaternion.identity);

        Invoke("SpawnItem", Random.Range(0.0f, spawnTime));
    }
}
