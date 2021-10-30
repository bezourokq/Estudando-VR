using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand_Controller : MonoBehaviour
{
    public GameObject hand_model;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(hand_model, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
