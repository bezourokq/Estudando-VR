using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlace //piece
{
    string name;
    float direction;
    int position;
    GameObject piece;

    public BoardPlace(string name,float direction,int position,GameObject piece)
    {
        this.name = name;
        this.direction = direction;
        this.position = position;
        this.piece = piece;
    }

    public string getName()
    {
        return name;
    }

    public float getDirection()
    {
        return direction;
    }

    public float getPosition()
    {
        return position;
    }

    public GameObject getPiece()
    {
        return piece;
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
