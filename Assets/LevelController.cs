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
    string pieceCount1, pieceCount2, pieceCount3, pieceCount4, pieceCount5;
    public GameObject win1, lose1;
    public Material material1, material2, material3, material4, material5, material6;
    public GameObject Level1, Level2;
    public GameObject switch1, switch2;
    public GameObject switchbar1a, switchbar1b, switchbar2a, switchbar2b;

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
        switchbar1a.GetComponent<MeshRenderer>().enabled = false;
        pieceCount1 = "0";
        pieceCount2 = "0";
        pieceCount3 = "0";
        pieceCount4 = "0";
        pieceCount5 = "0";
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
                    pieceCount1 = "0";
                    for (int n = 0; n < 2; n++)
                    {
                        if (boardVector[n] != null && boardVector[n].getType() == 1)
                        {
                            if (boardVector[n].getDirection() == 0)
                            {
                                pieceCount1 = pieceCount1 + n.ToString() + "10";
                                //yellow resistor
                                setCollor(boardVector[n], 2, 2);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount1 = pieceCount1 + n.ToString() + "10";
                                //yellow resistor
                                setCollor(boardVector[n], 2, 2);
                            }
                        }
                        if (boardVector[n] != null && boardVector[n].getType() == 2)
                        {

                            if (boardVector[n].getDirection() == 0)
                            {
                                pieceCount1 = pieceCount1 + n.ToString() + "20";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount1 = pieceCount1 + n.ToString() + "21";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                        }

                    }


                    Debug.Log("Codigo Final" + pieceCount1);
                    if (pieceCount1 == "0021110")
                    {
                        Debug.Log("win");
                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(Level1, 1);

                        setColorLed(boardVector[0], true);
                        win1.SetActive(true);
                        //green led and resdistor
                    }
                    if (pieceCount1 == "0010121")
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
                pieceCount2 = "0";
                for (int n = 0; n < 4; n++)
                {
                    if (boardVector[n] != null && boardVector[n].getType() == 0)
                    {

                        if (boardVector[n].getDirection() == 0)
                        {
                            pieceCount2 = pieceCount2  + "00";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2  + "00";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                    }
                    if (boardVector[n] != null && boardVector[n].getType() == 1)
                    {
                        if (boardVector[n].getDirection() == 0)
                        {
                            pieceCount2 = pieceCount2  + "10";
                            //yellow resistor
                            setCollor(boardVector[n], 2, 2);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2  + "10";
                            //yellow resistor
                            setCollor(boardVector[n], 2, 2);
                        }
                    }
                    if (boardVector[n] != null && boardVector[n].getType() == 2)
                    {

                        if (boardVector[n].getDirection() == 0)
                        {
                            pieceCount2 = pieceCount2 + "20";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                            setColorLed(boardVector[n], false);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2  + "21";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                            setColorLed(boardVector[n], false);
                        }
                    }
                    if (boardVector[n] != null && boardVector[n].getType() == 3)
                    {

                        if (boardVector[n].getDirection() == 0)
                        {
                            pieceCount2 = pieceCount2  + "30";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2 + "30";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                    }
                }


                Debug.Log("Codigo Final " + pieceCount2);

                //led acende normal
                if (pieceCount2 == "02110" || pieceCount2 == "01021") 
                
                {
                    Debug.Log("solucao 1");
                    setCollor(boardVector[0], 1, 1);
                    setCollor(boardVector[1], 1, 1);
                    setCollor(boardVector[2], 1, 1);
                    setCollor(boardVector[3], 1, 1);
                    setColorLed(boardVector[0], true);
                    setColorLed(boardVector[2], true);
                    setCollorChild(Level2, 1);
                }

                //led acende com o switch
                if (pieceCount2 == "0302110" || 
                    pieceCount2 == "0301021" || 
                    pieceCount2 == "0213010" || 
                    pieceCount2 == "0211030")
                {
                    Debug.Log("solucao 1");
                    setCollor(boardVector[0], 1, 1, 2);
                    setCollor(boardVector[1], 1, 1, 2);
                    setCollor(boardVector[2], 1, 1, 2);
                    setCollor(boardVector[3], 1, 1, 2);
                    setColorLed(boardVector[0], false);
                    setColorLed(boardVector[2], false);
                    setCollorChild(Level2, 1);
                }

                // curto com o fio faz queimar o led
                if (pieceCount2 == "02100" || 
                    pieceCount2 == "00021" || 
                    pieceCount2 == "0102100" ||
                    pieceCount2 == "0100021" ||
                    pieceCount2 == "0210010" ||
                    pieceCount2 == "0211000")
                {
                    setCollor(boardVector[0], 1, 1);
                    setCollor(boardVector[1], 1, 1);
                    setCollor(boardVector[2], 1, 1);
                    setCollor(boardVector[3], 1, 1);
                    setColorLed(boardVector[0], false);
                    setColorLed(boardVector[1], false);
                    setColorLed(boardVector[2], false);
                    setColorLed(boardVector[3], false);
                    setParticle(boardVector[0]);
                    setParticle(boardVector[1]);
                    setParticle(boardVector[2]);
                    setParticle(boardVector[3]);

                    setCollorChild(Level2, 1);
                }

                //switch faz queimar o led
                if (pieceCount2 == "02130" ||
                    pieceCount2 == "03021" ||
                    pieceCount2 == "0102130" ||
                    pieceCount2 == "021103000" ||
                    pieceCount2 == "021003010" ||
                    pieceCount2 == "030002110" ||
                    pieceCount2 == "031002100") 
                {
                    setCollor(boardVector[0], 1, 1);
                    setCollor(boardVector[1], 1, 1);
                    setCollor(boardVector[2], 1, 1);
                    setCollor(boardVector[3], 1, 1);
                    setColorLed(boardVector[0], false);
                    setColorLed(boardVector[1], false);
                    setColorLed(boardVector[2], false);
                    setColorLed(boardVector[3], false);
                    setParticle(boardVector[0]);
                    setParticle(boardVector[1]);
                    setParticle(boardVector[2]);
                    setParticle(boardVector[3]);

                    setCollorChild(Level2, 1);
                }

                if (pieceCount2 == "0001021" ||
                    pieceCount2 == "0002110" )
                {
                    setCollor(boardVector[0], 1, 1, 2);
                    setCollor(boardVector[1], 1, 1, 2);
                    setCollor(boardVector[2], 1, 1, 2);
                    setCollor(boardVector[3], 1, 1, 2);
                }

                    break;
            case 3:
                try
                {
                    pieceCount3 = "0";
                    for (int n = 0; n < 3; n++)
                    {
                        if (boardVector[n] != null && boardVector[n].getType() == 1)
                        {
                            if (boardVector[n].getDirection() == 0)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "10";
                                //yellow resistor
                                setCollor(boardVector[n], 2, 2);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "10";
                                //yellow resistor
                                setCollor(boardVector[n], 2, 2);
                            }
                        }
                        if (boardVector[n] != null && boardVector[n].getType() == 2)
                        {

                            if (boardVector[n].getDirection() == 0)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "20";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "21";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                        }

                    }

                    Debug.Log("Codigo Final " + pieceCount3);
                }
                catch
                {
                    break;
                }
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

    private void setCollor(Piece piece, int color1, int color2, int type)
    {

        try
        {   
            if(piece.getType() != type)
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

    private void setCollorChild(GameObject line, int color1)
    {

        try
        {
            foreach (Transform child in line.transform)
            {

                child.gameObject.GetComponent<MeshRenderer>().material = getCollor(color1);
                
            }
        }
        catch
        {

        }
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

    public void setSwitch(int board)
    {
        if(switch1.name == "3switch")
        {
            switch1.name = "5switch";
            switchbar1a.GetComponent<MeshRenderer>().enabled = true;
            switchbar1b.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            switch1.name = "3switch";
            switchbar1a.GetComponent<MeshRenderer>().enabled = false;
            switchbar1b.GetComponent<MeshRenderer>().enabled = true;
        }
        controller(2, board2);
    }
}

