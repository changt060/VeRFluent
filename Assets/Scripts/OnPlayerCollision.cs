using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerCollision : MonoBehaviour {

    public AudioSource grannySource2;
    public AudioClip grannyAudio2;

    void OnCollisionStay(Collision other)
    {
        if(other.gameObject.tag=="Player")
        {
            grannySource2.clip = grannyAudio2;
            grannySource2.Play();
            Debug.Log("Audio2Play");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            grannySource2.clip = grannyAudio2;
            grannySource2.Play();
            Debug.Log("Audio2Play");
        }
    }
    void doSomething()
    {
        Debug.Log("butts");
    }
}
