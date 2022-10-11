using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTime : MonoBehaviour
{
    public static FruitTime instantiateFruitTime;
    public List<Boat> boats = new List<Boat>();
    public Timer time;
    public void ChangeTime()
    {
        time.timeValue = 7f;
    }
    void Start()
    {
        MakeSingleton();
        //TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
    }
    void MakeSingleton()
    {
        if (instantiateFruitTime == null)
        {
            instantiateFruitTime = this;
        }
    }

    private void Update()
    {
        if (time.timeValue == 0)
        {
            TimeEffect();
            time.timeValue = 7f;
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
        }
    }

    public void TimeEffect()
    {
        for (int i = 0; i < 4; i++)
        {

            if (boats[i].ProtectEffect == true)
            {
                boats[i].ProtectEffect = false;
            }
            else
            {
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    if (boats[i].number == 1)
                    {
                        boats[i].MoveBack3();
                        TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                    }
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    if (boats[i].number == 2)
                    {
                        boats[i].MoveBack3();
                        TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                    }
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    if (boats[i].number == 3)
                    {
                        boats[i].MoveBack3();
                        TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                    }
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    if (boats[i].number == 4)
                    {
                        boats[i].MoveBack3();
                        TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                    }
                }
            }
        }
    }
}
