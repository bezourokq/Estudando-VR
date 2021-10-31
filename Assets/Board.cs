using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject temp;
    public GameObject temp1;
    public GameObject temp2;
    public GameObject temp3;
    public float position;
    // Start is called before the first frame update
    void Start()
    {
        //temp.transform.position = new Vector3(gameObject.transform.position.x - position, gameObject.transform.position.y, gameObject.transform.position.z);
        //temp1.transform.position = new Vector3(gameObject.transform.position.x + position, gameObject.transform.position.y, gameObject.transform.position.z);
        temp2.transform.position = new Vector3(gameObject.transform.position.x - position, gameObject.transform.position.y, gameObject.transform.position.z+position);
        temp2.transform.eulerAngles = new Vector3(0, getRotation(temp2.transform.eulerAngles.y), 0);

        //temp3.transform.position = new Vector3(gameObject.transform.position.x + position, gameObject.transform.position.y, gameObject.transform.position.z-position);

    }

    // Update is called once per frame
    void Update()
    {

    }


    float getRotation(float y)
    {
        
        if (y < 0)
            y = -y;
        Debug.Log(y);
        if ((y<= 45 && y>=0) || (y > 325))
            return 0;
        else if ((y <= 135 && y > 45))
            return 90;
        else if ((y <= 225 && y > 135))
            return 180;
        else 
            return 270;
    }
}
