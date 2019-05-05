using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class GameScript : MonoBehaviour {
    //public gameObject playerObj = gameObject.GetComponent();

    //put this at the start of your script
    GameObject PlayerObject;
    //Player player = Player.instance;//creates a reference to your player
    //Rigidbody rb;

    // Use this for initialization
    void Start () {
        //play audio
        //rb = player.GetComponent<Rigidbody>();//or you can use transform as well

        PlayerObject = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(PlayerObject.transform.position);
    }


}
