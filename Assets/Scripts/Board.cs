using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Board : MonoBehaviour
{
    public int board, position;
    bool isHolding;
    string holdingName;
    int direction;

    // Start is called before the first frame update
    void Start()
    {
        holdingName = "";
        isHolding = false;
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
            isHolding = true;
            direction = getRotation(collision.gameObject.transform.eulerAngles.y);
            
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.transform.position = myChild.gameObject.transform.position;
            holdingName = collision.gameObject.name;

            GameObject.Find("Level").GetComponent<LevelController>().setState(board,position, new Piece(int.Parse(collision.gameObject.name.Substring(0, 1)), direction, collision.gameObject));
            //Debug.Log(int.Parse(myChild.gameObject.name.Substring(0, 1)));
            //Debug.Log(collision.gameObject.name);
            //Debug.Log(int.Parse(collision.gameObject.name.Substring(0, 1)));int.Parse(collision.gameObject.name.Substring(0, 1))

            collision.gameObject.transform.eulerAngles = new Vector3(0, getRotation(collision.gameObject.transform.eulerAngles.y), 0);
            collision.gameObject.GetComponent<OutlineController>().addHolder(myChild.gameObject.name);
            myChild.gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private int getRotation(float y)
    {
        if (y < 0)
            y = -y;
        if ((y <= 45 && y >= 0) || (y > 325))
            return 0;
        else if ((y <= 135 && y > 45))
            return 90;
        else if ((y <= 225 && y > 135))
            return 180;
        else
            return 270;
    }
}
