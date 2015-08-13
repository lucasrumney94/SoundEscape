using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class dayDetector : MonoBehaviour {
	
	public bool day = true;
	public float transitionTime = 1.0f;
	
	
	public AudioMixer myAudioMixer;
	public AudioMixerSnapshot daySnapshot;
	public AudioMixerSnapshot nightSnapshot;
	
	
	// Use this for initialization
	void Start () 
	{
		daySnapshot = myAudioMixer.FindSnapshot("Day");
		nightSnapshot = myAudioMixer.FindSnapshot("Night");
		
		if (transform.position.y > 0)
			day = true;
		else 
			day = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (transform.position.y > 0)
			day = true;
		else 
			day = false;
		
		if (day)
		{
			daySnapshot.TransitionTo(transitionTime);
		}
		else 
		{
			nightSnapshot.TransitionTo(transitionTime);
		}
	}
}
