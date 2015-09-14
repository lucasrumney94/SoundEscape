using UnityEngine;
using System.Collections;

public class lightRotator : MonoBehaviour {
	
	public float degreePerFixedUpdate = .05f;


	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.RotateAround(Vector3.zero, Vector3.right, degreePerFixedUpdate);
	}
}