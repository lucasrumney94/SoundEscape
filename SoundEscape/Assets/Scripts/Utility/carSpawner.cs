using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class carSpawner : MonoBehaviour {

	public float speed = .5f;
	public int lowCarDelay = 1;
	public int highCarDelay = 10;

	//private Vector3 carDirection = new Vector3(1.0f,0.0f,0.0f);
	private Object carPrefab;
	private List<GameObject> cars;
	private int carDelay;

	// Use this for initialization
	void Start () 
	{
		cars = new List<GameObject>();
		carPrefab = Resources.Load("carPrefab");
		carDelay = Random.Range(lowCarDelay, highCarDelay);

		StartCoroutine("carTimer");
	}
	
	// Update is called once per frame
	void Update () 
	{
//		Debug.Log(cars.Count);
		foreach (GameObject c in cars)
		{
			c.transform.position += speed * transform.forward;
		}
	}


	void addCar()
	{
		cars.Add((GameObject) Instantiate(carPrefab, transform.position, Quaternion.identity));
		cars[cars.Count-1].transform.parent = transform;
		//cars[cars.Count-1].transform.localPosition = transform.position;
		//cars[cars.Count-1].transform.position = Vector3.zero;

	}




	IEnumerator carTimer()
	{
		for (;;) //always
		{
			addCar();
			carDelay = Random.Range(lowCarDelay, highCarDelay);
			yield return new WaitForSeconds(carDelay);
		}
	}
}