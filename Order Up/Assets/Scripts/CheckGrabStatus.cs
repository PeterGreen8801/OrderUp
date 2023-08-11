using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckGrabStatus : MonoBehaviour
{
    public XRDirectInteractor leftDirectInteractor;
    public XRDirectInteractor rightDirectInteractor;



    private void Start()
    {

    }

    private void Update()
    {
    }

    public void check()
    {
        if (leftDirectInteractor.hasSelection)
        {
            Debug.Log("The LEFTXRDirectInteractor is currently grabbing an object.");
        }
        else
        {
            Debug.Log("The LEFTXRDirectInteractor is not grabbing any object.");
        }
        if (rightDirectInteractor.hasSelection)
        {
            Debug.Log("The RIGHTXRDirectInteractor is currently grabbing an object.");
        }
        else
        {
            Debug.Log("The RIGHTXRDirectInteractor is not grabbing any object.");
        }
    }

    public void Haptics()
    {
        if (leftDirectInteractor.hasSelection)
        {
            leftDirectInteractor.SendHapticImpulse(0.5f, 0.25f);
            Debug.Log("The LEFTXRDirectInteractor is currently grabbing an object.");

        }
        if (rightDirectInteractor.hasSelection)
        {
            rightDirectInteractor.SendHapticImpulse(0.5f, 0.25f);
            Debug.Log("The RIGHTXRDirectInteractor is currently grabbing an object.");
        }
    }

    public bool checkLeftGrab()
    {
        if (leftDirectInteractor.hasSelection)
        {
            leftDirectInteractor.SendHapticImpulse(0.5f, 0.25f);
            Debug.Log("The LEFTXRDirectInteractor is currently grabbing an object.");
            return true;

        }
        else
        {
            Debug.Log("The LEFTXRDirectInteractor is not grabbing any object.");
            return false;
        }
    }

    public bool checkRightGrab()
    {
        if (rightDirectInteractor.hasSelection)
        {
            rightDirectInteractor.SendHapticImpulse(0.5f, 0.25f);
            Debug.Log("The RIGHTXRDirectInteractor is currently grabbing an object.");
            return true;
        }
        else
        {
            Debug.Log("The RIGHTXRDirectInteractor is not grabbing any object.");
            return false;
        }
    }
}

