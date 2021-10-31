using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }
    public void setOutlineTrue()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void setOutlineFalse()
    {
        gameObject.GetComponent<Outline>().enabled = false;

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

    }
}
