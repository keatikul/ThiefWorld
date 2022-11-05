using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSiren : MonoBehaviour
{
    public int currentTurnUsed;
    public int fininshTurn;
    public int currentTurnUsed2;
    public int fininshTurn2;
    public int currentTurnUsed3;
    public int fininshTurn3;
    public int currentTurnUsed4;
    public int fininshTurn4;
    public List<Boat> boats = new List<Boat>();
    public bool stillEffect;
    public bool stillEffect2;
    public bool stillEffect3;
    public bool stillEffect4;
    public int i;
    public Timer time;
    //public Text timeText;

    //start turn
    //Use Effect
    //Turn is Effct Activate**********
    //Check turn ว่า Effect ถูกใช้ Turn ไหน
    //boats[i].SirenEffcet = true (ตัวเรือ bool sireneffct = true)
    //คำนวนว่า Effect จะหมด Turn ไหน
    //After Turn Effect Activate******
    //Check if Still in Effect
    //Button Roll is not active
    //then Change to another player turn
    //if Effect is over then go back to normal

    public void Start()
    {
        
        //TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
    }

    /*void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float secounds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, secounds);
    }*/

    public void Update()
    {
       
        if (time.timeValue == 0)
        {
            SirenEffect();
            time.timeValue = 7f;
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
        }
        

        //SirenEffect();
        if (stillEffect == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
        {
            CheckfinishTurn();
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            /*if (stillEffect == true)
            {
                //TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            }*/
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            
        }
        if (stillEffect2 == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
        {
            CheckfinishTurn();
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            /*if (stillEffect2 == true)
            {
                //TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            }*/
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            
        }
        if (stillEffect3 == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
        {
            CheckfinishTurn();
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            /*if (stillEffect3 == true)
            {
                //TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            }*/
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            
        }
        if (stillEffect4 == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
        {
            CheckfinishTurn();
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            /*if (stillEffect4 == true)
            {
                //TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            }*/
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
            
        }
    }


    public void CheckfinishTurn()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount > fininshTurn)
        {
            stillEffect = false;
            for (i = 0; i < boats.Count; i++)
            {
                if (stillEffect == false && boats[i].number == 1)
                {
                    if (boats[i].SirenEffect == true)
                    {
                        boats[i].SirenEffect = false;
                    }
                }
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount > fininshTurn2)
        {
            stillEffect2 = false;
            for (i = 0; i < boats.Count; i++)
            {
                if (stillEffect2 == false && boats[i].number == 2)
                {
                    if (boats[i].SirenEffect == true)
                    {
                        boats[i].SirenEffect = false;
                    }
                }
            }

        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount > fininshTurn3)
        {
            stillEffect3 = false;
            for (i = 0; i < boats.Count; i++)
            {
                if (stillEffect3 == false && boats[i].number == 3)
                {
                    if (boats[i].SirenEffect == true)
                    {
                        boats[i].SirenEffect = false;
                    }
                }
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount > fininshTurn4)
        {
            stillEffect4 = false;
            for (i = 0; i < boats.Count; i++)
            {
                if (stillEffect4 == false && boats[i].number == 4)
                {
                    if (boats[i].SirenEffect == true)
                    {
                        boats[i].SirenEffect = false;
                    }
                }
            }
        }
        

    }



    public void SirenEffect()
    {
        for (i = 0; i < 4; i++)
        {
            if (boats[i].ProtectEffect == true)
            {
                boats[i].ProtectEffect = false;
            }
            else
            {
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    
                    if (boats[i].number == 1 && boats[i].SirenEffect == true)
                    {
                        
                        currentTurnUsed = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn = currentTurnUsed + 1;
                        stillEffect = true;
                       
                    }
                    
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    if (boats[i].number == 2 && boats[i].SirenEffect == true)
                    {
                       
                        currentTurnUsed2 = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn2 = currentTurnUsed2 + 1;
                        stillEffect2 =true;
                    }
                    
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    if (boats[i].number == 3 && boats[i].SirenEffect == true)
                    {
                        currentTurnUsed3 = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn3 = currentTurnUsed3 + 1;
                        stillEffect3 = true;
                    }
                    
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    if (boats[i].number == 4 && boats[i].SirenEffect == true)
                    {
                        currentTurnUsed4 = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn4 = currentTurnUsed4 + 1;
                        stillEffect4 = true;
                    }
                    
                }
              
            }
        }

       
        
    }


    public void ChangeTime()
    {
        time.timeValue = 7f;
        if (time.timeValue == 0)
        {
            SirenEffect();
        }
    }
    
}
