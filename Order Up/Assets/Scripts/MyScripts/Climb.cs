using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Climb : XRBaseInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {

        Climber.climbingHand = args.interactorObject.transform.GetComponent<ActionBasedController>();
        base.OnSelectEntered(args);
    }


    protected override void OnSelectExited(SelectExitEventArgs args)
    {

        if (Climber.climbingHand && Climber.climbingHand.name == args.interactorObject.transform.name)
        {
            Climber.climbingHand = null;
        }
        base.OnSelectExited(args);
    }

    /*
        [System.Obsolete]
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);
        //Can add to make specific direct interactor
        Climber.climbingHand = interactor.GetComponent<XRController>();
    }

    [System.Obsolete]
    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);

        if (Climber.climbingHand && Climber.climbingHand.name == interactor.name)
        {
            Climber.climbingHand = null;
        }
    }
    */
}
