using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTrigger : MonoBehaviour {
    private int touched = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getTouch()
    {
        return touched;
    }

    void OnTriggerEnter(Collider other)
    {
        touched = 1;
        
    }
}
