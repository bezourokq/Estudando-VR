using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlace
{
    string name;
    float direction;

    public BoardPlace(string name,float direction)
    {
        this.name = name;
        this.direction = direction;
    }

    public string getName()
    {
        return name;
    }

    public float getDirection()
    {
        return direction;
    }
}
