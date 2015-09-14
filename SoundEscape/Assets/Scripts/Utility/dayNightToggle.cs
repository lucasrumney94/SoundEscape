using UnityEngine;
using System.Collections;

public class dayNightToggle : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.T))
		{
			//transform.position = -transform.position;
			transform.RotateAround(Vector3.zero, Vector3.right, 180);
		}
	}
}
