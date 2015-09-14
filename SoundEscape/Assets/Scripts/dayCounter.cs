using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dayCounter : MonoBehaviour {

    public int day = 1;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
        gameObject.GetComponent<Text>().text = "Day " + day.ToString();
	}
}
