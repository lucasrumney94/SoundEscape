using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class carSpawner : MonoBehaviour {
	
	public int lowCarDelay = 1;
	public int highCarDelay = 10;

	//private Vector3 carDirection = new Vector3(1.0f,0.0f,0.0f);

	private List<Object> carPrefabs;
	private List<GameObject> cars;

	private int carDelay;

	//Need to gain access to Day bool in dayDetector script to change to less cars at night! /2



	// Use this for initialization
	void Start () 
	{

		Random.seed = gameObject.GetInstanceID();
		cars = new List<GameObject>();
		carPrefabs = new List<Object>();
		carPrefabs.Add (Resources.Load("carPrefab"));
		carPrefabs.Add (Resources.Load("car2Prefab"));
		carDelay = Random.Range(lowCarDelay, highCarDelay);

		StartCoroutine("carTimer");
	}
	



	void addCar()
	{
		//Debug.Log(Random.Range(0,carPrefabs.Count));
		cars.Add((GameObject) Instantiate(carPrefabs[Random.Range(0,carPrefabs.Count)], transform.position, transform.rotation));
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