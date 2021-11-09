using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle
{
    string name;
    float solution;

    public bool PuzzleValidator(BoardPlace[] boardMap,int level)
    {
        foreach (BoardPlace b in boardMap)
        {
            try
            {
                solution = solution + b.getType()*b.getPosition() + b.getDirection();
            }
            catch
            {

            }
        }
        Debug.Log(solution);
        return true;
    }
}
