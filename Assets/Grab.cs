using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grab : MonoBehaviour
{
    public GameObject tankyou;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "controller")
        {
            Debug.Log("Picked Up");
            tankyou.SetActive(true);
            // if dumpling is grabbed, show instructions
            // press to record/stop
            // ceck if result matches
        }
    }

}
