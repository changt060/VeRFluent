using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class GrannyScript : MonoBehaviour {
    public AudioSource grannySource1;
    public AudioClip grannyAudio1;

 //   public AudioSource grannySource2;
 //   public AudioClip grannyAudio2;

    // Use this for initialization
    void Start () {
        grannySource1.clip = grannyAudio1;
        grannySource1.Play();
        Debug.Log("Audio1Play");
	}
	
	// Update is called once per frame
    /*
	void Update () {
        int ctrig = GameObject.Find("TriggerDetect").GetComponent<TriggerDetect>().getTouch();
        if (ctrig == 1)
        {
            grannySource1.clip = grannyAudio2;
            grannySource1.Play();
            Debug.Log("Audio2Play");

        }
    }
    */
    
}
