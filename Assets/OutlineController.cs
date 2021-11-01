using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class OutlineController : MonoBehaviour
{
    // Start is called before the first frame update
    private XRGrabInteractable interactor;

    void Start()
    {
        interactor = gameObject.GetComponent<XRGrabInteractable>();
        interactor.hoverEntered.AddListener(OnHoverEnter);
        interactor.hoverExited.AddListener(OnHoverExited);
    }

    public void setOutlineTrue()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void setOutlineFalse()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    void Update()
    {

    }

    private void OnHoverEnter(HoverEnterEventArgs interactable)
    {
        foreach (Canvas panel in gameObject.GetComponentsInChildren(typeof(Canvas)))
        {
            panel.enabled = true;
        }
        setOutlineTrue();
    }

    private void OnHoverExited(HoverExitEventArgs interactable)
    {
        foreach (Canvas panel in gameObject.GetComponentsInChildren(typeof(Canvas)))
        {
            panel.enabled = false;
        }   
        setOutlineFalse();
    }

}

