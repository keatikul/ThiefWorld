using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScriptSinglePlay : MonoBehaviour
{
    public static TurnScriptSinglePlay instantiateTurnsingle;
    public GameObject buttonCanvas;
    //public GameObject _NextTurnCanvas;
    public GameObject Player1;
    public GameObject player2Bot;
    public GameObject player3Bot;
    public GameObject player4Bot;
    public Boat[] Players;
    public List<Boat> boats = new List<Boat>();
    public List<int> Numbersboat = new List<int>();
    //public bool turn1;


    public GameObject currentTurnPlayer;
    public GameObject nextPlayer;
    public float timeValue = 15f;
    public float timeEnd = 3f;


    //public float NextturnCanvas = 3f;
    public int turn;
    public int index;
    public int currentNumber;
    public int NextNumber;
    public int NextNumber3;
    public int NextNumber4;


    public int botroll;


    public int Turn1;
    public int Turn2;
    public int Turn3;
    public int Turn4;


    public bool checkTurn1;
    public bool checkTurn2;
    public bool checkTurn3;
    public bool checkTurn4;


    public bool endTurn1;
    //public int min = 1;
    //public int max = 5;
    public int randomNumber;
    //public List<int> numberPot = new List<int>();
    void Start()
    {
        SimpleRandom();
        MakeSingleton();
        {
        //Numbersboat[0] = Boat.instanceBoatt.number;
        //Debug.Log("Boat Number:" + Players[0]);
        /*int startNumber = 1;
        int endNumber = 4;
        for (int i = startNumber; i < endNumber + 1; i++)
        {
            numberPot.Add(i);
            //Debug.Log(numberPot[2]);
        }
        while (numberPot.Count > 0)
        {
            index = Random.Range(0, numberPot.Count);
            randomNumber = numberPot[index];
            //currentNumber = numberPot[index];
            numberPot.RemoveAt(index);
            //currentNumber = previousNumber;
            Debug.Log(randomNumber);
            RandomPlayer();
            //Debug.Log(previousNumber);
        }*/
        //RandomPlayer();
        //buttonCanvas.SetActive(false);
        
        //NumberPlayer();
        }
        Debug.Log("Start Game");
    }

    void Update()
    {
       CheckTurn();
       //SwitchTurn();
    }
    void MakeSingleton()
    {
        if (instantiateTurnsingle == null)
        {
            instantiateTurnsingle = this;
        }
    }
    public void TimeCount()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        if (timeValue == 0)
        {
            //EndTurn();
        }
    }

    public void TimeEnd()
    {
        if (timeEnd > 0)
        {
            timeEnd -= Time.deltaTime;
        }
        else
        {
            timeEnd = 0;
        }
    }


    public void NumberPlayer()
    {
        //Turn1
        //turn1 = true;
        Debug.Log("NumberPlayer()");
        if (checkTurn1 == true) 
        {
            if (Numbersboat[0] == 1)
            {
                Players[0].number = 1;
                Players[0].CharacterMoveWithTurn();
                Debug.Log("If Numberboat0:");
            }
            if (Numbersboat[0] == 2)
            {
                Players[1].number = 1;
                Players[1].CharacterMoveWithTurn();
                Debug.Log("If Numberboat0:");
            }
            if (Numbersboat[0] == 3)
            {
                Players[2].number = 1;
                Players[2].CharacterMoveWithTurn();
                Debug.Log("If Numberboat0:");
            }
            if (Numbersboat[0] == 4)
            {
                Players[3].number = 1;
                Players[3].CharacterMoveWithTurn();
                Debug.Log("If Numberboat0:");
            }
        }

        //Turn2
        if (checkTurn2 == true) 
        {
            if (Numbersboat[1] == 1 && Turn2 == 1)
            {
                Players[0].number = 2;
                Players[0].CharacterMoveWithTurn();
            }
            if (Numbersboat[1] == 2 && Turn2 == 2)
            {
                Players[1].number = 2;
                Players[1].CharacterMoveWithTurn();
            }
            if (Numbersboat[1] == 3 && Turn2 == 3)
            {
                Players[2].number = 2;
                Players[2].CharacterMoveWithTurn();
            }
            if (Numbersboat[1] == 4 && Turn2 == 4)
            {
                Players[3].number = 2;
                Players[3].CharacterMoveWithTurn();
            }
        }
        //Turn3
        if (checkTurn3 == true)
        {
            if (Numbersboat[2] == 1 && Turn3 == 1)
            {
                Players[0].number = 3;
                Players[0].CharacterMoveWithTurn();
            }
            if (Numbersboat[2] == 2 && Turn3 == 2)
            {
                Players[1].number = 3;
                Players[1].CharacterMoveWithTurn();
            }
            if (Numbersboat[2] == 3 && Turn3 == 3)
            {
                Players[2].number = 3;
                Players[2].CharacterMoveWithTurn();
            }
            if (Numbersboat[2] == 4 && Turn3 == 4)
            {
                Players[3].number = 3;
                Players[3].CharacterMoveWithTurn();
            }
        }
        //Turn4
        if (checkTurn4 == true)
        {
            if (Numbersboat[3] == 1 && Turn4 == 1)
            {
                Players[0].number = 4;
                Players[0].CharacterMoveWithTurn();
            }
            if (Numbersboat[3] == 2 && Turn4 == 2)
            {
                Players[1].number = 4;
                Players[1].CharacterMoveWithTurn();
            }
            if (Numbersboat[3] == 3 && Turn4 == 3)
            {
                Players[2].number = 4;
                Players[2].CharacterMoveWithTurn();
            }
            if (Numbersboat[3] == 4 && Turn4 == 4)
            {
                Players[3].number = 4;
                Players[3].CharacterMoveWithTurn();
            }
        }
    }

    public void BotRoll()
    {
        botroll = Random.Range(1, 7);
        Debug.Log("Bot Roll" + botroll);

    }
    public void SimpleRandom()
    {
        //Random 1st Trun
        index = Random.Range(1, 5);
        Numbersboat.Add(index);
        Debug.Log("NumberBoat[]:"+Numbersboat[0]);
        currentNumber = index;
        Turn1 = Numbersboat[0];
        Debug.Log("Turn1:"+Turn1);
        Debug.Log(currentNumber);
        if (index == 1)
        {
            currentTurnPlayer = Player1;
           //Debug.Log("turn1");
        }
        if (index == 2)
        {
            currentTurnPlayer = player2Bot;
            //Debug.Log("turn2");

        }
        if (index == 3) 
        {
            currentTurnPlayer = player3Bot;
           // Debug.Log("turn3");

        }
        if (index == 4)
        {
            currentTurnPlayer = player4Bot;
            //Debug.Log("turn4");
        }
        //Random 2nd Trun
        index = Random.Range(1, 5);
        //Numbersboat.Add(index);
        Debug.Log("Next Player is2: "+ index);
        NextNumber = index;
        while (index == currentNumber)
        {
            index = Random.Range(1, 5);
            Debug.Log("Same Player Random agian:" + index);
            NextNumber = index;
        }
        Numbersboat.Add(index);
        Turn2 = Numbersboat[1];
        Debug.Log("Turn2:" + Numbersboat[1]);
        if (index != currentNumber)
        {
            if (NextNumber == 1)
            {
                nextPlayer = Player1;
            }
            if (NextNumber == 2)
            {
                nextPlayer = player2Bot;
            }
            if (NextNumber == 3)
            {
                nextPlayer = player3Bot;
            }
            if (NextNumber == 4)
            {
                nextPlayer = player4Bot;
            }
        }
        //Random 3rd Turn
        index = Random.Range(1, 5);
        Debug.Log("Next Player is3: " + index);
        NextNumber3 = index;
        while(index == Turn1 || index == Turn2)
        { 
                index = Random.Range(1, 5);
                Debug.Log("Same Player Random agian3: " + index);
                NextNumber3 = index;
        }
        Numbersboat.Add(index);
        Turn3 = Numbersboat[2];
        Debug.Log("Turn3: " + Numbersboat[2]);

        //Random 4th Turn
        index = Random.Range(1, 5);
        Debug.Log("Next Player is4: " + index);
        NextNumber4 = index;
        while (index == Turn1 || index == Turn2 || index == Turn3)
        {
            index = Random.Range(1, 5);
            Debug.Log("Same Player Random agian4: " + index);
            NextNumber4 = index;
        }
        Numbersboat.Add(index);
        Turn4 = Numbersboat[3];
        Debug.Log("Turn4: " + Numbersboat[3]);
    }


    public void CheckTurn()
    {
        {       
            /*switch(index)
        {
            case 1:
                //Start Turn 1
                TimeCount();
                NumberPlayer();
                checkTurn1 = true;
                checkTurn2 = false;
                checkTurn3 = false;
                checkTurn4 = false;
                if (Turn1 == 1)
                {
                    //buttonCanvas.SetActive(true);
                }
                else
                {
                    //BotRoll();
                }
                if (timeValue == 0)
                {
                    checkTurn1 = false;
                    //timeValue = 15f;
                }
                break;
            case 2:
                //Start Turn 2
                checkTurn1 = false;
                checkTurn2 = true;
                checkTurn3 = false;
                checkTurn4 = false;
                if (checkTurn2 == true)
                {
                    TimeCount();
                    NumberPlayer();

                    if (Turn2 == 1)
                    {
                        //buttonCanvas.SetActive(true);
                    }
                }
                break;
        }*/
        /*for (int ii = 0; ii < Turn2; ii++)
        {
            
                //Start Turn 1
                TimeCount();
                NumberPlayer();
                checkTurn1 = false;
                checkTurn2 = true;
                checkTurn3 = false;
                checkTurn4 = false;
                if (Turn2 == 1)
                {
                    //buttonCanvas.SetActive(true);
                }
                else
                {
                    //BotRoll();
                }
                /*if (timeValue == 0)
                {
                    checkTurn1 = false;
                    //timeValue = 15f;
               
            
        }*/
        }
        //Start Turn
        //CheckPlayer
        //Timecount
        //PlayerMove
        //EndTurn (After Player Move || Times up)
        //After Endturn (Time = 15 || go next turn)
        if (checkTurn2 == false && checkTurn3 == false && checkTurn4 == false)
        {
            checkTurn1 = true;
            if (Turn1 == 1 || Turn1 == 2 || Turn1 == 3 || Turn1 == 4)
            {
                //Start Turn 1
                TimeCount();
                NumberPlayer();
                if (Turn1 == 1)
                {
                    //buttonCanvas.SetActive(true);
                }
            else
            {
                //BotRoll();
            }
            if (timeValue == 0 && checkTurn1 == true)
            {
                checkTurn1 = false;
                Debug.Log("Times up");
                EndTurn();
                //timeValue = 15f;
            }
            }
        }
     

        if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false)
        {
            checkTurn2 = true;
            //timeValue = 15f;
            Debug.Log("checkTurn2 = true");
           if (checkTurn2 == true)
            {
                Debug.Log("this");
                //timeValue = 15f;
                //checkTurn1 = false;
                if (Turn2 == 1 || Turn2 == 2 || Turn2 == 3 || Turn2 == 4)
                {
                    //timeValue = 15f;
                    TimeCount();
                    NumberPlayer();
                    if (Turn2 == 1)
                    {
                        //buttonCanvas.SetActive(true);
                    }
                    if (timeValue == 0 && checkTurn2 == true)
                    {
                        Debug.Log("here");
                        checkTurn2 = false;
                        EndTurn();
                        //checkTurn3 = true;
                    }
                }
            }
        }
        if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false)
        {
            checkTurn3 = true;
            //timeValue = 15f;
            if (Turn3 == 1 || Turn3 == 2 || Turn3 == 3 || Turn3 == 4)
            {
                TimeCount();
                NumberPlayer();
                if (Turn3 == 1)
                {
                    //buttonCanvas.SetActive(true);
                }
                if (timeValue == 0 && checkTurn3 == true) 
                {
                    checkTurn3 = false;
                    EndTurn();
                    //checkTurn4 = true;
                }
            }
        }

        if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false)
        {
            checkTurn4 = true;
            //timeValue = 15f;
            if (Turn4 == 1 || Turn4 == 2 || Turn4 == 3 || Turn4 == 4)
            {
                TimeCount();
                NumberPlayer();
                if (Turn4 == 1)
                {
                    //buttonCanvas.SetActive(true);
                }
                if (timeValue == 0 && checkTurn4 == true)
                {
                    checkTurn4 = false;
                    EndTurn();
                    //checkTurn4 = true;
                }
            }
        }

    }

    public void SwitchTurn()
    {
        //RandomPlayer();
        if (currentTurnPlayer == Player1)
        {
            TurnPlayer1();
            Debug.Log("Current Turn 1");
        }
        if (currentTurnPlayer == player2Bot)
        {
            Debug.Log("Current Turn 2");
            TurnPlayer2();
        }
    }

    public void EndTurn()
    {
        //currentTurnPlayer = nextPlayer;
        timeValue = 15f;
    }
    public void TurnPlayer1()
    {
        
        //currentTurnPlayer = Player1;
        //nextPlayer = player2Bot;
        //TimeCount();
        //player2Bot.SetActive(false);
        //player3Bot.SetActive(false);
        //player4Bot.SetActive(false);
        buttonCanvas.SetActive(true);
        if (PowerUp.instancePowerUp.isPowerUp == true)
        {
            //timeValue = 0;
        }
        if (timeValue == 0 && Boat.instanceBoatt.isMoving == false)
        {
            EndTurn();
        }

    }

    public void TurnPlayer2()
    {
        //currentTurnPlayer = player2Bot;
        //Boat.instanceBoatt.enabled = true;
        //nextPlayer = player3Bot;
        //TimeCount();
        player2Bot.SetActive(true);
        buttonCanvas.SetActive(true);
        //Player1.SetActive(false);
        if (timeValue == 0 && Boat.instanceBoatt.isMoving == false)
        {
            EndTurn();
        }
    }
}
