using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece
{
    int type;
    int direction;
    GameObject piece;

    public Piece(int type,int direction, GameObject piece)
    {
        this.type = type;
        this.direction = direction;
        this.piece = piece;
    }

    public int getType()
    {
        return type;
    }

    public int getDirection()
    {
        return direction;
    }

    public GameObject getPiece()
    {
        return piece;
    }
}
