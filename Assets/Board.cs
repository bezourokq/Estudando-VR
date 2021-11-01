using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Piece"))
        {
            Collider myChild = collision.contacts[0].thisCollider;
            collision.gameObject.transform.position = myChild.gameObject.transform.position;
            collision.gameObject.transform.eulerAngles = new Vector3(0, getRotation(collision.gameObject.transform.eulerAngles.y), 0);
            collision.gameObject.GetComponent<OutlineController>().addHolder(myChild.gameObject);
            myChild.enabled = false;
        }

    }




    private float getRotation(float y)
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
