using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpeechController : MonoBehaviour {

    public Image speechBubble;
    public Text speechText;

    public string[] speech = 
    {
        "You suck",
        "Hahahaha",
        " ¯\\_(ツ)_/¯",
        "360 NO SCOPE"
    };

    public float speechRandomTime = 5.0f;

	// Use this for initialization
	void Start () {
        Invoke("Talk", Random.Range(0.0f, speechRandomTime));
	}
	
	// Update is called once per frame
	void Talk () {
        speechText.text = speech[Random.Range(0, speech.Length - 1)];

        speechBubble.gameObject.SetActive(true);
        speechText.gameObject.SetActive(true);

        Invoke("StopTalk", Random.Range(0.0f, speechRandomTime));
	}

    void StopTalk()
    {
        speechBubble.gameObject.SetActive(false);
        speechText.gameObject.SetActive(false);

        Invoke("Talk", Random.Range(0.0f, speechRandomTime));
    }
}
