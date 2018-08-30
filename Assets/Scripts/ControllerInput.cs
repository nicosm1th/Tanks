using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    public Tank tank;
    public PlayerController playerController;

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

        playerController = new PlayerController(tank);

    }

    void Update()
    {
        if (Controller.GetAxis() != Vector2.zero)
        {
            Debug.Log(gameObject.name + Controller.GetAxis());
        }

        if (Controller.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " Trigger Press");
        }

        if (Controller.GetHairTrigger())
        {
            Debug.Log(gameObject.name + " Trigger Held");
            OnTriggerHold();
        }

        if (Controller.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " Trigger Release");
            OnTriggerRelease();
        }

        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Press");
        }

        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Release");
        }
    }

    void OnTriggerHold()
    {
        playerController.Accelerate();
    }

    void OnTriggerRelease()
    {
        playerController.Deccelerate();
    }
}


