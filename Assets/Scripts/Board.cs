using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    bool isHolding;
    string holdingName;
    float direction;
    BoardPlace[] boardMap;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        boardMap = new BoardPlace[10];
        holdingName = "";
        isHolding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 6)
        {
             
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Piece"))
        {
            Collider myChild = collision.contacts[0].thisCollider;
            isHolding = true;
            direction = getRotation(collision.gameObject.transform.eulerAngles.y);
            //Debug.Log(int.Parse(myChild.gameObject.name.Substring(0, 1)));
            boardMap.SetValue(new BoardPlace(collision.gameObject.name, direction), int.Parse(myChild.gameObject.name.Substring(0, 1)));
            count++;
            foreach (BoardPlace b in boardMap)
            {
                try
                {
                   
                    Debug.Log(b.getType() + " " + b.getDirection() + " tamanho " + count);
                }
                catch
                {

                }
            }

            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.transform.position = myChild.gameObject.transform.position;
            holdingName = collision.gameObject.name;

            
            collision.gameObject.transform.eulerAngles = new Vector3(0, getRotation(collision.gameObject.transform.eulerAngles.y), 0);
            collision.gameObject.GetComponent<OutlineController>().addHolder(myChild.gameObject.name);
            myChild.gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {

    }




    private float getRotation(float y)
    {
        if (y < 0)
            y = -y;
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
