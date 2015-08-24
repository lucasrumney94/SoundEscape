using UnityEngine;
using System.Collections;

public class carMove : MonoBehaviour {
	public float speed = .4f;

	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.position += speed * transform.forward;
	}
}
