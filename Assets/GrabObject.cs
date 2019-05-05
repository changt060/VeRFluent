using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class ViveGrabObject : MonoBehaviour
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

    public GameObject collidingObject;//To keep track of what objects have rigidbodies
    public GameObject objectInHand;//To track the object you're holding

    void OnTriggerEnter(Collider other)//Activate function in trigger zone, checking rigidbodies and ignoring if no rigidbodies 
    {
        if (!other.GetComponent<Rigidbody>())
        {
            return;
        }
        collidingObject = other.gameObject;//If rigidbody, then assign object to collidingObject variable
    }

    void OnTriggerExit(Collider other)
    {
        collidingObject = null;
    }

    void Update()
    {
        if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger))// Push grip buttons and touching object, set GrabObject function
             //Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip)
        {
            if (collidingObject)
            {
                GrabObject();
            }
        }
        if (ViveInput.GetPressUp(HandRole.RightHand, ControllerButton.Trigger))// If release grip buttons and holding object, set to release
             //Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip)
        {
            if (objectInHand)
            {
                ReleaseObject();
            }
        }
    }

    private void GrabObject() // Picking up object and assigning objectInHand variable
    {
        objectInHand = collidingObject;
        objectInHand.transform.SetParent(this.transform);
        objectInHand.GetComponent<Rigidbody>().isKinematic = true;
    }
    // Releasing object and disabling kinematic functionality so other forces can affect object
    private void ReleaseObject()
    {
        objectInHand.GetComponent<Rigidbody>().isKinematic = false;
        objectInHand.transform.SetParent(null);
    }
}