using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitStolen : MonoBehaviour
{
    public static FruitStolen instantiateFruitStolen;
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

    private void Update()
    {
        if (time.timeValue == 0)
        {
            StolenEffect();
            time.timeValue = 7f;
            //Debug.Log("time = 0 auto effect");
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
        }
    }
    void MakeSingleton()
    {
        if (instantiateFruitStolen == null)
        {
            instantiateFruitStolen = this;
        }
    }

    public void StolenEffect()
    {
        for (int i = 0; i < 4; i++)
        {
            
            if (boats[i].ProtectEffect == true)
            {
                boats[i].Playerpoint -= 0;
                boats[i].ProtectEffect = false;
            }
            else
            {
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true) 
                {
                    if (boats[i].number == 1)
                    {
                        TurnScriptSinglePlay.instantiateTurnsingle.Players[i].Playerpoint += 4;
                        
                    }   
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    if (boats[i].number == 2)
                    {
                        TurnScriptSinglePlay.instantiateTurnsingle.Players[i].Playerpoint += 4;
                        
                    }
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    if (boats[i].number == 3)
                    {
                        TurnScriptSinglePlay.instantiateTurnsingle.Players[i].Playerpoint += 4;
                        
                    }
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    if (boats[i].number == 4)
                    {
                        TurnScriptSinglePlay.instantiateTurnsingle.Players[i].Playerpoint += 4;
                        
                    }
                }
                boats[i].Playerpoint -= 1;
                /*boats[i].iconFruit.SetActive(true);
                boats[i].g_icontext.SetActive(true);
                boats[i].icontext.text = "-1";*/
            }
        }

        
    }

 
    
}
