using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class OutlineController : MonoBehaviour
{


    private GameObject box;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetBox(GameObject box)
    {
        this.box = box;
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

    private void HoverEnterEvent(Collision collision)
    {
        try
        {
            gameObject.GetComponent<Canvas>().enabled = false;
        }
        catch{

        }
        Debug.Log(collision.gameObject.name);
        setOutlineTrue();
    }

    private void HoverExitedEvent(Collision collision)
    {
        try
        {
            gameObject.GetComponent<Canvas>().enabled = false;
        }
        catch
        {

        }
        Debug.Log(collision.gameObject.name);
        setOutlineFalse();
    }

    public void drop()
    {
        
    }

    public void pickUp()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        box.SetActive(true);
    }
}

