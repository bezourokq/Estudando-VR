using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Hand_Controller : MonoBehaviour
{
    public GameObject hand_model;
    public bool hand;
    private GameObject handGameObject;
    private InputDeviceCharacteristics ControllerC;
    private InputDevice targetDevice;
    private Animator handAnimator;
    private GameObject spawnedHand;
    private bool raycastOn;
    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        if (hand)
        {
            ControllerC = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
            handGameObject = GameObject.Find("Ray Interactor Right");
        }
        else
        {
            ControllerC = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
            handGameObject = GameObject.Find("Ray Interactor Left");
        }
        InputDevices.GetDevicesWithCharacteristics(ControllerC, devices);
        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        raycastOn = false;

        spawnedHand = Instantiate(hand_model, transform);
        
        //spawnedHand.AddComponent<Rigidbody>();
        //spawnedHand.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //spawnedHand.AddComponent<SphereCollider>();
        //spawnedHand.GetComponent<SphereCollider>().isTrigger = true;
        //spawnedHand.GetComponent<SphereCollider>().radius = 0.05f;
        handAnimator = spawnedHand.GetComponent<Animator>();


    }

    void UpdateHandAnimation()
    {
        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryValue ) && primaryValue)
        {
            handGameObject.GetComponent<XRRayInteractor>().enabled = raycastOn;
            raycastOn = !raycastOn;
        }
        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
        {
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Trigger", 0);
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue) && gripValue > 0.1f)
        {
            handAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHandAnimation();
    }
}
