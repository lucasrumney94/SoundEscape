using UnityEngine;
using System.Collections;

public class destroyCollided : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
	}

}
