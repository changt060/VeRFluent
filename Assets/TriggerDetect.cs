using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class TriggerDetect : MonoBehaviour {
    public AudioSource grannySource2;
    public AudioClip grannyAudio2;
    public bool play=true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
        if (play)
        {
            grannySource2.clip = grannyAudio2;
            grannySource2.Play();
            Debug.Log("Audio2Play");
            play = false;
        }

    }
}
