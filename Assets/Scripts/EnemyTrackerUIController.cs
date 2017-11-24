using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTrackerUIController : MonoBehaviour {

    public Image trackerImage;

    private List<Image> images;
    private float startSpawn = -93f;
	
	public void SpawnImages(float num)
    {
        images = new List<Image>();

        for(int i = 0; i < num; i++)
        {
            Image o = Instantiate(trackerImage, new Vector2(-93.0f * (i+1) - 40, -93), Quaternion.identity) as Image;

            o.transform.SetParent(this.transform, false);

            images.Add(o);
        }
    }

    public void RemoveImage()
    {
        images.RemoveAt(images.Count - 1);
        Destroy(this.transform.GetChild(this.transform.childCount - 1).gameObject);
    }
}
