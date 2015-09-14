using UnityEngine;
using System.Collections;

public class rotateMe : MonoBehaviour {

    public float speed = 0.5f;
    public Vector3 axis;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.Rotate(axis, speed);
	}
}
