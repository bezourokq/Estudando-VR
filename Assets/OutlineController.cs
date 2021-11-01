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
        interactor.hoverEntered.
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

    private void OnHoverEnter(XRBaseInteractable interactable)
    {
        foreach (Canvas panel in gameObject.GetComponentsInChildren(typeof(Canvas)))
        {
            panel.enabled = true;
        }
        setOutlineTrue();
    }

    private void OnHoverExited(XRBaseInteractable interactable)
    {
        foreach (Canvas panel in gameObject.GetComponentsInChildren(typeof(Canvas)))
        {
            panel.enabled = false;
        }   
        setOutlineFalse();
    }

}

