using UnityEngine;
using System.Collections;

public class nightToDayIncrement : MonoBehaviour {

    public bool day;
    public bool dayWasFalse;
    private float dayValue = 1.0f;

    private GameObject dayCount;

	// Use this for initialization
	void Start ()
    {
        dayValue = gameObject.transform.position.y;
        dayCount = GameObject.FindGameObjectWithTag("dayCounterText");
	}
	
	// Update is called once per frame
	void Update ()
    {
        dayValue = gameObject.transform.position.y;
        if (dayValue > 0 && dayWasFalse)
        {
            dayCount.GetComponent<dayCounter>().day += 1;
            dayWasFalse = false;
            day = true;
        }
        else if (dayValue <= 0)
        {
            dayWasFalse = true;
            day = false;
        }

    }
}
