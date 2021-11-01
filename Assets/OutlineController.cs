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
    private GameObject piece;
    private String holder;

    void Start()
    {
        interactor = gameObject.GetComponent<XRGrabInteractable>();
        interactor.hoverEntered.AddListener(OnHoverEnter);
        interactor.hoverExited.AddListener(OnHoverExited);
        foreach (Canvas panel in gameObject.GetComponentsInChildren(typeof(Canvas)))
        {
            panel.enabled = false;
        }
    }

    public void setOutlineTrue()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void addHolder(String myChild)
    {
        holder = myChild;
    }

    public void setOutlineFalse()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    void Update()
    {

    }

    public GameObject GetPiece()
    {
        return piece;
    }

    private void OnHoverEnter(HoverEnterEventArgs interactable)
    {
        foreach (Canvas panel in gameObject.GetComponentsInChildren(typeof(Canvas)))
        {
            panel.enabled = true;
        }
        
        piece = interactable.interactable.gameObject;
        
        if (interactable.interactor.gameObject.GetComponent<Hand_Controller>().getGrip())
        {
            try
            {
                Debug.Log(piece.name + "piece");
                Debug.Log(interactable.interactor.gameObject.name + "hand");
                Debug.Log(holder + " holder");
                //piece.transform.parent = null;
                //piece.GetComponent<Rigidbody>().isKinematic = false;
                //GameObject.Find(holder).GetComponent<BoxCollider>().isTrigger = false;
            }
            catch
            {

            }

        }
        else
        {
            //piece.GetComponent<Rigidbody>().isKinematic = true;
        }


        setOutlineTrue();
    }

    private void OnHoverExited(HoverExitEventArgs interactable)
    {
        foreach (Canvas panel in gameObject.GetComponentsInChildren(typeof(Canvas)))
        {
            panel.enabled = false;
        }
        //piece.GetComponent<Rigidbody>().isKinematic = false;
        //piece = null;
        setOutlineFalse();
    }

}

