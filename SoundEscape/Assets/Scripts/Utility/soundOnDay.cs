using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class soundOnDay : MonoBehaviour {

    public int dayActivate; 

    private int dayCount;
    private AudioSource mySound;
    private bool playOnce = false;
    

    void Start()
    {
        dayCount = GameObject.FindGameObjectWithTag("dayCounterText").GetComponent<dayCounter>().day;
        mySound = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (dayCount == dayActivate)
        {
            playOnce = true;
           
        }

        if (playOnce)
        {
            mySound.Play();
            playOnce = false;
        }

    }
}
