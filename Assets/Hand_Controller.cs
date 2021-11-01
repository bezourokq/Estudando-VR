using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Hand_Controller : MonoBehaviour
{
    public GameObject hand_model;
    private GameObject handGameObject;
    private InputDeviceCharacteristics ControllerC;
    private InputDevice targetDevice;
    private Animator handAnimator;
    private GameObject spawnedHand;
    private bool raycastOn,grip;
    private GameObject objectGR;
    private GameObject pointer;

    Component[] animator;

    
    // Start is called before the first frame update
    void Start()
    {
        grip = false;
        setUp();
    }

    void setUp()
    {

        List<InputDevice> devices = new List<InputDevice>();

        if (gameObject.name.Contains("Right"))
        {
            ControllerC = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
            handGameObject = GameObject.Find("RightHand");
        }
        else
        {
            ControllerC = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
            handGameObject = GameObject.Find("LeftHand");
        }
        InputDevices.GetDevicesWithCharacteristics(ControllerC, devices);
        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }
        animator = gameObject.GetComponentsInChildren(typeof(Animator));
        raycastOn = false;
    }

    void UpdateHandAnimation()
    {
        if(animator.Length == 0)
            animator = gameObject.GetComponentsInChildren(typeof(Animator));

        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryValue ) && primaryValue)
        {
            gameObject.GetComponent<XRRayInteractor>().enabled = raycastOn;
            
            raycastOn = !raycastOn;
        }
        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
        {
            foreach (Animator anim in animator)
                anim.SetFloat("Trigger", triggerValue);
        }
        else
        {
            foreach (Animator anim in animator)
                anim.SetFloat("Trigger", 0);
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue) && gripValue > 0.1f)
        {
            grip = true;
            foreach (Animator anim in animator)
                anim.SetFloat("Grip", gripValue);
        }
        else
        {
            grip = false;
            foreach (Animator anim in animator)
                anim.SetFloat("Grip", 0);
        }
    }

    public bool getGrip()
    {
        return grip;
    }

    void Update()
    {
        UpdateHandAnimation();
    }

    void SetPointer(GameObject pointer)
    {
        this.pointer = pointer;
    }

    private void OnCollisionStay(Collision collision)
    {
        try
        {
            if (targetDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool gripValue) && gripValue)
            {
                if (collision.gameObject.tag.Contains("Interactable"))
                {
                    collision.transform.parent = transform;
                    collision.rigidbody.isKinematic = true;
                    objectGR = collision.gameObject;
                }
            }
            else
            {
                if (objectGR.transform.parent != null)
                {
                    objectGR.GetComponent<Rigidbody>().isKinematic = false;
                    objectGR.transform.parent = null;
                }
            }
        }
        catch
        {

        }
        
    }

    public void vibrate()
    {
        targetDevice.SendHapticImpulse(0, 1, 0.5f);
    }
}
