using UnityEngine;
using System.Collections;

public class skyboxChanger : MonoBehaviour {

	public float speedOfChange = 1f;
	public Color dayBlue;
	public Color nightBlue;
	public bool day = true;
	public GameObject sun;

	private MeshRenderer mRenderer;
	private Material skybox;
	private float interpolator = 0;

	// Use this for initialization
	void Start () 
	{
		mRenderer = gameObject.GetComponent<MeshRenderer>();
		skybox = mRenderer.materials[0];


		//skybox.set;
		//gameObject.GetComponent<Renderer>().material.SetColor(nightBlue);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (sun.transform.position.y > 50)
			day = true;
		else 
			day = false;


		if (day)
			interpolator -= speedOfChange;
		else 
			interpolator += speedOfChange;

		skybox.SetColor("_Tint",Color.Lerp(dayBlue,nightBlue,interpolator));
	}
}
