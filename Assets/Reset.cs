using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject o1, o2, o3, o4, o5, o6;
    public Transform temp1, temp2, temp3, temp4, temp5, temp6;
    public GameObject c1, c2, c3, c4, c5, c6,c7,c8,c9;
    public BoxCollider tc1, tc2, tc3, tc4, tc5, tc6, tc7, tc8, tc9;
    void Start()
    {
        temp1 = o1.transform;
        temp2 = o2.transform;
        temp3 = o3.transform;
        temp4 = o4.transform;
        temp5 = o5.transform;
        temp6 = o6.transform;

        
    }

    // Update is called once per frame
    public void reset()
    {
        o1.transform.position = temp1.position;
        o2.transform.position = temp2.position;
        o3.transform.position = temp3.position;
        o4.transform.position = temp4.position;
        o5.transform.position = temp5.position;
        o6.transform.position = temp6.position;
    }
}
