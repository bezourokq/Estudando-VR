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
    public GameObject player;
    public GameObject playerStartPosition;
    public GameObject playerPosition1, playerPosition2, playerPosition3, playerPosition4, playerPosition5;
    string pieceCount1, pieceCount2, pieceCount3, pieceCount4, pieceCount5;
    public GameObject win1, lose1;
    public Material material1, material2, material3, material4, material5, material6;
    public GameObject Level1, Level2, level3;
    public GameObject switch1, switch2;
    public GameObject switchbar1a, switchbar1b, switchbar2a, switchbar2b;
    private int level;

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
        level = 0;
        //player.transform.position = playerStartPosition.transform.position;
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
                        if (boardVector[n] != null && boardVector[n].getType() == 0)
                        {

                            if (boardVector[n].getDirection() == 0)
                            {
                                pieceCount1 = pieceCount1 + n.ToString() + "00";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount1 = pieceCount1 + n.ToString() + "00";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                        }
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
                    if (pieceCount1 == "0021110" ||
                        pieceCount1 == "0010121")
                    {
                        Debug.Log("win");
                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(Level1, 1);

                        setColorLed(boardVector[0], true);
                        setColorLed(boardVector[1], true);
                        win1.SetActive(true);
                        //green led and resdistor
                    }
                    if (pieceCount1 == "0000121" ||
                        pieceCount1 == "0021100")
                    {
                        Debug.Log("Queimou");
                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(Level1, 1);
                        setParticle(boardVector[0]);
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
                            pieceCount2 = pieceCount2 + n.ToString() + "00";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2 + n.ToString() + "00";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                    }
                    if (boardVector[n] != null && boardVector[n].getType() == 1)
                    {
                        if (boardVector[n].getDirection() == 0)
                        {
                            pieceCount2 = pieceCount2 + n.ToString() + "10";
                            //yellow resistor
                            setCollor(boardVector[n], 2, 2);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2 + n.ToString() + "10";
                            //yellow resistor
                            setCollor(boardVector[n], 2, 2);
                        }
                    }
                    if (boardVector[n] != null && boardVector[n].getType() == 2)
                    {

                        if (boardVector[n].getDirection() == 0)
                        {
                            pieceCount2 = pieceCount2 + n.ToString() + "20";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                            setColorLed(boardVector[n], false);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2 + n.ToString() + "21";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                            setColorLed(boardVector[n], false);
                        }
                    }
                    if (boardVector[n] != null && boardVector[n].getType() == 3)
                    {

                        if (boardVector[n].getDirection() == 0)
                        {
                            pieceCount2 = pieceCount2 + n.ToString() + "30";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                        else if (boardVector[n].getDirection() == 180)
                        {
                            pieceCount2 = pieceCount2 + n.ToString() + "30";
                            //yellow led
                            setCollor(boardVector[n], 2, 2);
                        }
                    }
                }

                setCollorChild(Level2, 2);
                Debug.Log("Codigo Final " + pieceCount2);

                //led acende normal
                if (pieceCount2 == "0021110" ||
                    pieceCount2 == "0110221" ||
                    pieceCount2 == "0010121" ||
                    pieceCount2 == "0121210" ||
                    pieceCount2 == "0210321" ||
                    pieceCount2 == "0221310" ||
                    pieceCount2 == "0021310" ||
                    pieceCount2 == "0010321")


                {
                    Debug.Log("solucao 1");
                    setCollor(boardVector[0], 1, 1);
                    setCollor(boardVector[1], 1, 1);
                    setCollor(boardVector[2], 1, 1);
                    setCollor(boardVector[3], 1, 1);
                    setColorLed(boardVector[0], true);
                    setColorLed(boardVector[1], true);
                    setColorLed(boardVector[2], true);
                    setColorLed(boardVector[3], true);
                    setCollorChild(Level2, 1);
                }

                //led acende com o switch
                if (pieceCount2 == "0000110221" ||
                    pieceCount2 == "0000221310" ||
                    pieceCount2 == "0021110200" ||
                    pieceCount2 == "0021100310")
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
                if (pieceCount2 == "0021100" ||
                    pieceCount2 == "0000121" ||
                    pieceCount2 == "0000321" ||
                    pieceCount2 == "0021300" ||
                    pieceCount2 == "0221300" ||
                    pieceCount2 == "0100221" ||
                    pieceCount2 == "0121200" ||
                    pieceCount2 == "0110200321" ||
                    pieceCount2 == "0121200310" ||
                    pieceCount2 == "0021210300" ||
                    pieceCount2 == "0021110300" ||
                    pieceCount2 == "0000121210" ||
                    pieceCount2 == "0100221310" ||
                    pieceCount2 == "0000210321" ||
                    pieceCount2 == "0010221300" ||
                    pieceCount2 == "0110221300" ||
                    pieceCount2 == "0010100221")
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

                //curto circuito
                if (pieceCount2 == "0000100" ||
                    pieceCount2 == "0000300" ||
                    pieceCount2 == "0200100" ||
                    pieceCount2 == "0200300" ||
                    pieceCount2 == "0100200310" ||
                    pieceCount2 == "0010100200" ||
                    pieceCount2 == "0010200300" ||
                    pieceCount2 == "0110200300" ||
                    pieceCount2 == "0000110300" ||
                    pieceCount2 == "0000210300" ||
                    pieceCount2 == "0000100210" ||
                    pieceCount2 == "0000100310" ||
                    pieceCount2 == "0100200321" ||
                    pieceCount2 == "0021100200" ||
                    pieceCount2 == "0021200300" ||
                    pieceCount2 == "0121200300" ||
                    pieceCount2 == "0000121300" ||
                    pieceCount2 == "0000221300" ||
                    pieceCount2 == "0000100221" ||
                    pieceCount2 == "0000100321")
                {

                    Debug.Log("Curto na fonte");
                }

                if (pieceCount2 == "0000110" ||
                    pieceCount2 == "0110200" ||
                    pieceCount2 == "0010100" ||
                    pieceCount2 == "0100210" ||
                    pieceCount2 == "0210300" ||
                    pieceCount2 == "0200310" ||
                    pieceCount2 == "0000310" ||
                    pieceCount2 == "0010300")
                {
                    setCollor(boardVector[0], 1, 1, 2);
                    setCollor(boardVector[1], 1, 1, 2);
                    setCollor(boardVector[2], 1, 1, 2);
                    setCollor(boardVector[3], 1, 1, 2);
                    setCollorChild(Level2, 1);
                }

                break;
            case 3:
                try
                {
                    pieceCount3 = "0";
                    for (int n = 0; n < 3; n++)
                    {
                        if (boardVector[n] != null && boardVector[n].getType() == 0)
                        {

                            if (boardVector[n].getDirection() == 0)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "00";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "00";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                        }
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
                                setColorLed(boardVector[n], false);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "21";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                                setColorLed(boardVector[n], false);
                            }
                        }
                        if (boardVector[n] != null && boardVector[n].getType() == 5)
                        {

                            if (boardVector[n].getDirection() == 0)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "30";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                            else if (boardVector[n].getDirection() == 180)
                            {
                                pieceCount3 = pieceCount3 + n.ToString() + "30";
                                //yellow led
                                setCollor(boardVector[n], 2, 2);
                            }
                        }

                    }



                    Debug.Log("Codigo Final " + pieceCount3);
                    if (pieceCount3 == "0030110221" ||
                        pieceCount3 == "0021110230" ||
                        pieceCount3 == "0110221" ||
                        pieceCount3 == "0021110" ||
                        pieceCount3 == "0010121" ||
                        pieceCount3 == "0121210" ||
                        pieceCount3 == "0010121230" ||
                        pieceCount3 == "0030121210")
                    {
                        Debug.Log("win");
                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(boardVector[2], 1, 1);
                        setCollorChild(level3, 1);

                        setColorLed(boardVector[0], true);
                        setColorLed(boardVector[1], true);
                        setColorLed(boardVector[2], true);

                        //win1.SetActive(true);
                        //green led and resdistor
                    }
                    if (pieceCount3 == "0010130221" ||
                        pieceCount3 == "0021130210" ||
                        pieceCount3 == "0130221" ||
                        pieceCount3 == "0021130" ||
                        pieceCount3 == "0121230" ||
                        pieceCount3 == "0030121230" ||
                        pieceCount3 == "0021110200" ||
                        pieceCount3 == "0000110221")
                    {
                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(boardVector[2], 1, 1);
                        setCollorChild(level3, 1);
                        setColorLed(boardVector[0], false);
                        setColorLed(boardVector[2], false);
                    }
                    if (pieceCount3 == "0021100" ||
                        pieceCount3 == "0100221" ||
                        pieceCount3 == "0100221" ||
                        pieceCount3 == "0121200" ||
                        pieceCount3 == "0021100210" ||
                        pieceCount3 == "0021100230" ||
                        pieceCount3 == "0010100221" ||
                        pieceCount3 == "0030100221" ||
                        pieceCount3 == "0010121200" ||
                        pieceCount3 == "0000121210")
                    {

                        setCollor(boardVector[0], 1, 1);
                        setCollor(boardVector[1], 1, 1);
                        setCollor(boardVector[2], 1, 1);
                        setParticle(boardVector[0]);
                        setParticle(boardVector[1]);
                        setParticle(boardVector[2]);
                        setCollorChild(level3, 1);
                    }
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


    public void resetState()
    {

        board1 = new Piece[2];

        board2 = new Piece[4];

        board3 = new Piece[3];

        board4 = new Piece[7];

        board5 = new Piece[5];
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
        if (piece.getType() != type)
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

public void setCollorChild(GameObject line, int color1)
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
    if (switch1.name == "0switch")
    {
        switch1.name = "5switch";
        switchbar1a.GetComponent<MeshRenderer>().enabled = true;
        switchbar1b.GetComponent<MeshRenderer>().enabled = false;
    }
    else
    {
        switch1.name = "0switch";
        switchbar1a.GetComponent<MeshRenderer>().enabled = false;
        switchbar1b.GetComponent<MeshRenderer>().enabled = true;
    }
    controller(2, board2);
}

public void nextLevel()
{
    level = level + 1;
    teleportPlayer();
}

public void teleportPlayer()
{
    switch (level)
    {
        case 1:
            player.transform.position = playerPosition1.transform.position;
            break;
        case 2:
            player.transform.position = playerPosition2.transform.position;
            break;
        case 3:
            player.transform.position = playerPosition3.transform.position;
            break;
        case 4:
            player.transform.position = playerPosition4.transform.position;
            break;
        case 5:
            player.transform.position = playerPosition5.transform.position;
            break;
    }
}
}

