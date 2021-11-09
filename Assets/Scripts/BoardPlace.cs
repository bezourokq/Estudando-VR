using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlace //piece
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

    public int getType()
    {
        switch (name)
        {
            case "CableCurve":
                return 1;
            case "CableLine":
                return 2;
            case "Led":
                return 3;
            case "Resistor":
                return 4;
        }
        return 0;
    }
}
