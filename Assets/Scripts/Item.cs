using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName;
    public float points;
    public Color flashColour;

    private Image flashImage;

    void Start()
    {
        this.tag = "Item";
        flashImage = GameObject.Find("FlashImage").GetComponent<Image>();
        flashImage.color = flashColour;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<InventoryManager>().addItem(this.gameObject);
            Destroy(this.gameObject);
        }
    }
}
