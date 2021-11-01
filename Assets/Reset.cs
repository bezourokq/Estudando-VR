using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject o1, o2, o3, o4, o5, o6;
    public Vector3 temp1, temp2, temp3, temp4, temp5, temp6;
    public GameObject c1, c2, c3, c4, c5, c6,c7,c8,c9;
    public BoxCollider tc1, tc2, tc3, tc4, tc5, tc6, tc7, tc8, tc9;
    void Start()
    {
        temp1 = o1.transform.position;
        temp2 = o2.transform.position;
        temp3 = o3.transform.position;
        temp4 = o4.transform.position;
        temp5 = o5.transform.position;
        temp6 = o6.transform.position;

        
    }

    // Update is called once per frame
    public void reset()
    {
        o1.transform.SetPositionAndRotation(temp1, o1.transform.rotation);
        o1.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        o1.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        o1.GetComponent<Rigidbody>().isKinematic = false;
        o1.transform.parent = null;


        o2.transform.SetPositionAndRotation(temp2, o2.transform.rotation);
        o2.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        o2.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        o2.GetComponent<Rigidbody>().isKinematic = false;
        o2.transform.parent = null;

        o3.transform.SetPositionAndRotation(temp3, o3.transform.rotation);
        o3.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        o3.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        o3.GetComponent<Rigidbody>().isKinematic = false;
        o3.transform.parent = null;

        o4.transform.SetPositionAndRotation(temp4, o4.transform.rotation);
        o4.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        o4.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        o4.GetComponent<Rigidbody>().isKinematic = false;
        o4.transform.parent = null;

        o5.transform.SetPositionAndRotation(temp5, o5.transform.rotation);
        o5.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        o5.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        o5.GetComponent<Rigidbody>().isKinematic = false;
        o5.transform.parent = null;

        o6.transform.SetPositionAndRotation(temp6, o6.transform.rotation);
        o6.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        o6.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        o6.GetComponent<Rigidbody>().isKinematic = false;
        o6.transform.parent = null;



    }
}
