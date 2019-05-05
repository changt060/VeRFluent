using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class ViveGrabObject1 : MonoBehaviour
{
    //private SteamVR_TrackedObject trackedObj;
    //private SteamVR_Controller.Device Controller
    /*{
        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }*/
    void Awake()
    {
        //trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    public GameObject collidingObject1;//To keep track of what objects have rigidbodies
    public GameObject objectInHand1;//To track the object you're holding

    void OnTriggerEnter(Collider other)//Activate function in trigger zone, checking rigidbodies and ignoring if no rigidbodies 
    {
        if (!other.GetComponent<Rigidbody>())
        {
            return;
        }
        collidingObject1 = other.gameObject;//If rigidbody, then assign object to collidingObject variable
    }

    void OnTriggerExit(Collider other)
    {
        collidingObject1 = null;
    }

    void Update()
    {
        if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger))// Push grip buttons and touching object, set GrabObject function
             //Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip)
        {
            if (collidingObject1)
            {
                GrabObject1();
            }
        }
        if (ViveInput.GetPressUp(HandRole.RightHand, ControllerButton.Trigger))// If release grip buttons and holding object, set to release
             //Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip)
        {
            if (objectInHand1)
            {
                ReleaseObject1();
            }
        }
    }

    private void GrabObject1() // Picking up object and assigning objectInHand variable
    {
        objectInHand1 = collidingObject1;
        objectInHand1.transform.SetParent(this.transform);
        objectInHand1.GetComponent<Rigidbody>().isKinematic = true;
    }
    // Releasing object and disabling kinematic functionality so other forces can affect object
    private void ReleaseObject1()
    {
        objectInHand1.GetComponent<Rigidbody>().isKinematic = false;
        objectInHand1.transform.SetParent(null);
    }
}