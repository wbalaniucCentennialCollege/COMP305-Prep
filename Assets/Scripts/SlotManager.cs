using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour {

    public Sprite itemSprite;
    public int count = 0;

    private Image uiImage;

    void Start()
    {
        uiImage = this.GetComponent<Image>();
    }

    public void AddItem(Item it)
    {
        if(itemSprite == it.sprite)
        {
            count++;
            this.transform.GetComponentInChildren<Text>().text = count.ToString();
        }
        else
        {
            uiImage.sprite = it.sprite;
            // uiImage.GetComponent<Image>().color = new Color(uiImage.color.r, uiImage.color.g, uiImage.color.b, 255.0f);
        }
    }
}
