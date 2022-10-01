using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFreeze : MonoBehaviour
{
    public int currentTurnUsed;
    public int fininshTurn;
    public List<Boat> boats = new List<Boat>();
    public bool stillEffect;
    public bool stillEffect2;
    public bool stillEffect3;
    public bool stillEffect4;
    public int i;

    //start turn
    //Use Effect
    //Turn is Effct Activate**********
    //Check turn ??? Effect ?????? Turn ???
    //boats[i].SirenEffcet = true (??????? bool sireneffct = true)
    //???????? Effect ????? Turn ???
    //After Turn Effect Activate******
    //Check if Still in Effect
    //Button Roll is not active
    //then Change to another player turn
    //if Effect is over then go back to normal
    private void Start()
    {
        //TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
    }

    public void Update()
    {
        if (stillEffect == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            TurnScriptSinglePlay.instantiateTurnsingle.PlayerClick = true;
            if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount >= fininshTurn)
            {
                stillEffect = false;

            }
        }
        if (stillEffect2 == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            TurnScriptSinglePlay.instantiateTurnsingle.PlayerClick = true;
            if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount >= fininshTurn)
            {
                stillEffect2 = false;

            }
        }
        if (stillEffect3 == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            TurnScriptSinglePlay.instantiateTurnsingle.PlayerClick = true;
            if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount >= fininshTurn)
            {
                stillEffect3 = false;

            }
        }
        if (stillEffect4 == true && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            TurnScriptSinglePlay.instantiateTurnsingle.PlayerClick = true;
            if (TurnScriptSinglePlay.instantiateTurnsingle.TurnCount >= fininshTurn)
            {
                stillEffect4 = false;

            }
        }


    }
    public void FrezeEffect()
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

                    if (boats[i].number == 1 && boats[i].FreezeEffect == true)
                    {

                        currentTurnUsed = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn = currentTurnUsed + 1;
                        stillEffect = true;

                    }

                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    if (boats[i].number == 2 && boats[i].FreezeEffect == true)
                    {

                        currentTurnUsed = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn = currentTurnUsed + 1;
                        stillEffect2 = true;
                    }

                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    if (boats[i].number == 3 && boats[i].FreezeEffect == true)
                    {
                        currentTurnUsed = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn = currentTurnUsed + 1;
                        stillEffect3 = true;
                    }

                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    if (boats[i].number == 4 && boats[i].FreezeEffect == true)
                    {
                        currentTurnUsed = TurnScriptSinglePlay.instantiateTurnsingle.TurnCount;
                        fininshTurn = currentTurnUsed + 1;
                        stillEffect4 = true;
                    }

                }

            }
        }



    }

}
