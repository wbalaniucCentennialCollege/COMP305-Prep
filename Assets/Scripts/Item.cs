using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName;
    public float points;
    public Color flashColour;
    public Sprite sprite;

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
            other.gameObject.GetComponent<InventoryManager>().addItem(this.gameObject.GetComponent<Item>());
            // Destroy(this.gameObject);
            this.gameObject.SetActive(false);
            // other.gameObject.GetComponent<InventoryManager>().PrintList();
        }
    }
}
