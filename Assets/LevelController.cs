using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    Piece[] board1 = new Piece[2];
    Piece[] board2 = new Piece[4];
    Piece[] board3 = new Piece[3];
    Piece[] board4 = new Piece[7];
    Piece[] board5 = new Piece[5];
    int pieceCount1, pieceCount2, pieceCount3, pieceCount4, pieceCount5;
    public GameObject win1,lose1;
    public Material material1, material2, material3, material4,material5,material6;
    public GameObject Level1;
    // 0 is wire
    // 1 is a resistor
    // 2 is a led
    // 3 is a switch
    // 4 transistor
    //solution:
    //1. 02180110 ou 0218011180
    //2. 02180110230

    void Start()
    {

        pieceCount1 = 0;
        pieceCount2 = 0;
        pieceCount3 = 0;
        pieceCount4 = 0;
        pieceCount5 = 0;
        win1.SetActive(false);
        lose1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void controller(int board, Piece[] boardVector)
    {
        Debug.Log("Numero board " + board);
        foreach (Piece piece in boardVector)
        {
            try
            {
                //Debug.Log("Tipo peça " + piece.getType());
               // Debug.Log("Rotação peca " + piece.getDirection());
            }
            catch
            {

            }

        }

        switch (board)
        {

            
            case 1:
                try
                {
                    pieceCount1 = 0;
                    if (boardVector[0] != null && boardVector[0].getType() == 2)
                    {
                        if (boardVector[0].getDirection() == 180)
                        {
                            pieceCount1 = pieceCount1 + 1;
                            //yellow led
                            setCollor(boardVector[0],3,2);
                        }
                        else if (boardVector[0].getDirection() == 0)
                        {
                            pieceCount1 = pieceCount1 + 2;
                            //yellow led
                            setCollor(boardVector[0], 2, 2);
                        }
                    }
                    
                    if (boardVector[1] != null && boardVector[1].getType() == 2)
                    {
                        if (boardVector[1].getDirection() == 0)
                        {
                            pieceCount1 = pieceCount1 + 2;
                            //yellow led
                            setCollor(boardVector[1], 2, 2);
                        }
                        else if (boardVector[1].getDirection() == 180)
                        {
                            pieceCount1 = pieceCount1 + 2;
                            //yellow led
                            setCollor(boardVector[1], 2, 2);
                        }
                    }
                    if (boardVector[0] != null && boardVector[0].getType() == 1)
                    {
                        if (boardVector[0].getDirection() == 0 )
                        {
                            pieceCount1 = pieceCount1 + 10;
                            //yellow resistor
                            setCollor(boardVector[0], 2, 2);
                        }
                        else if (boardVector[0].getDirection() == 180)
                        {
                            pieceCount1 = pieceCount1 + 10;
                            //yellow resistor
                            setCollor(boardVector[0], 2, 2);
                        }
                    }

                    if (boardVector[1] != null && boardVector[1].getType() == 1)
                    {
                        if (boardVector[1].getDirection() == 0)
                        {
                            pieceCount1 = pieceCount1 + 10;
                            //yellow resistor
                            setCollor(boardVector[1], 2, 2);
                        }
                        else if (boardVector[1].getDirection() == 180)
                        {
                            pieceCount1 = pieceCount1 + 10;
                            //yellow resistor
                            setCollor(boardVector[1], 2, 2);
                        }
                    }


                    if (pieceCount1 == 11)
                    {
                        Debug.Log("win");
                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(Level1, 1);
                        
                        setColorLed(boardVector[0], true);
                        win1.SetActive(true);
                        //green led and resdistor
                    }
                    if (pieceCount1 == 12)
                    {
                        Debug.Log("Queimou");
                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(Level1, 1);
                        setParticle(boardVector[1]);
                        setColorLed(boardVector[1], false);
                        lose1.SetActive(true);
                        //green led and resdistor
                    }


                }
                catch
                {
                    break;
                }
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
        }


    }


    public void setState(int board, int position, Piece piece)
    {
        switch (board)
        {
            case 1:
                board1[position] = piece;
                controller(board, board1);
                break;
            case 2:
                board2[position] = piece;
                controller(board, board2);
                break;
            case 3:
                board3[position] = piece;
                controller(board, board3);
                break;
            case 4:
                board4[position] = piece;
                controller(board, board4);
                break;
            case 5:
                board5[position] = piece;
                controller(board, board5);
                break;
        }



    }

    public void resetState(int board)
    {

   


                
        switch (board)
        {
            case 1:
                setCollor(board1[0], 4, 4);
                setCollor(board1[1], 4, 4);
                board1 = new Piece[2];
                break;
            case 2:
                board2 = new Piece[4];
                break;
            case 3:
                board3 = new Piece[3];
                break;
            case 4:
                board4 = new Piece[7];
                break;
            case 5:
                board5 = new Piece[5];
                break;

        }
    }


    private void setCollor(Piece piece, int color1, int color2)
    {

        try
        {
            foreach (Transform child in piece.getPiece().transform)
            {
                if (child.name.Contains("left"))
                {
                    child.gameObject.GetComponent<MeshRenderer>().material = getCollor(color1);
                }
                if (child.name.Contains("right"))
                {
                    child.gameObject.GetComponent<MeshRenderer>().material = getCollor(color2);
                }
            }
        }
        catch
        {

        }
    }

    private void setColorLed(Piece piece, bool state)
    {
        try
        {
            foreach (Transform child in piece.getPiece().transform)
            {
                if (state)
                {
                    if (child.name.Contains("led"))
                    {
                        child.gameObject.GetComponent<MeshRenderer>().material = material4; ;
                    }
                }
                else
                {
                    if (child.name.Contains("led"))
                    {
                        child.gameObject.GetComponent<MeshRenderer>().material = material5; ;
                    }
                }
                
            }
        }
        catch
        {

        }
    }

    private void setParticle(Piece piece)
    {

        try
        {
            foreach (Transform child in piece.getPiece().transform)
            {
                if (child.name.Contains("Particle"))
                {
                   var em = child.gameObject.GetComponent<ParticleSystem>().emission;
                   em.enabled = true;


                }

            }
        }
        catch
        {

        }
    }

    private void setCollor(GameObject line, int color1)
    {
        line.GetComponent<MeshRenderer>().material = getCollor(color1);              
    }


    ///1 - green
    ///2 - yellow
    ///3 - black
    private Material getCollor(int color)
    {
        switch (color)
        {
            case 1:
                return material1;
                break;
            case 2:
                return material2;
                break;
            case 3:
                return material3;
                break;
            case 4:
                return material6;
                break;
            default:
                return null;
        }
                
    }
}

