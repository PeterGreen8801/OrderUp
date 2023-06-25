using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class Climber : MonoBehaviour
{
    public CharacterController character;
    public static ActionBasedController climbingHand;
    private ContinuousMoveProviderBase continuousMoveProviderBase;

    private ActionBasedController previousHand;
    private Vector3 previousPos;
    private Vector3 currentVelocity;

    // Start is called before the first frame update
    void Start()
    {
        continuousMoveProviderBase = GetComponent<ContinuousMoveProviderBase>();
    }

    void Update()
    {

        if (climbingHand)
        {
            if (previousHand == null)
            {
                previousHand = climbingHand;
                previousPos = climbingHand.positionAction.action.ReadValue<Vector3>();
            }
            if (climbingHand.name != previousHand.name)
            {
                previousHand = climbingHand;
                previousPos = climbingHand.positionAction.action.ReadValue<Vector3>();
                //Debug.Log("DIFFERENT HAND NOW");
            }
            continuousMoveProviderBase.enabled = false;
            Climb();
        }
        else
        {
            continuousMoveProviderBase.enabled = true;
        }
    }

    void Climb()
    {
        currentVelocity = (climbingHand.positionAction.action.ReadValue<Vector3>() - previousPos) / Time.deltaTime;
        character.Move(transform.rotation * -currentVelocity * Time.deltaTime);

        previousPos = climbingHand.positionAction.action.ReadValue<Vector3>();
    }

    /*
    private CharacterController character;
    public static XRController climbingHand;
    private ActionBasedContinuousMoveProvider actionBasedContinuousMoveProvider;

    void Start()
    {
        character = GetComponent<CharacterController>();
        actionBasedContinuousMoveProvider = GetComponent<ActionBasedContinuousMoveProvider>();
    }

    void FixedUpdate()
    {
        if (climbingHand)
        {
            actionBasedContinuousMoveProvider.enabled = false;
            Climb();
        }
        else
        {
            actionBasedContinuousMoveProvider.enabled = true;
        }
    }

    void Climb()
    {
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        character.Move(transform.rotation * -velocity * Time.fixedDeltaTime);
    }
    */
}
