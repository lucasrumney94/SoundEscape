using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class storyDelivery : MonoBehaviour {

    private int dayCount;

	// Use this for initialization
	void Start ()
    {
        dayCount = GameObject.FindGameObjectWithTag("dayCounterText").GetComponent<dayCounter>().day;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        dayCount = GameObject.FindGameObjectWithTag("dayCounterText").GetComponent<dayCounter>().day;

        if (dayCount == 5)
        {
            gameObject.GetComponent<Text>().text = "It is the Fifth Day!";
        }
        else
        {
            gameObject.GetComponent<Text>().text = "";
        }

    }
}
