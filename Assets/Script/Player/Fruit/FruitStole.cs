using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitStole : MonoBehaviour
{
   
    public static FruitStole instantiateFruitStole;
    public List<Boat> boats = new List<Boat>();
    private int i;
    void Start()
    {
        MakeSingleton();
        //TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
    }
    void MakeSingleton()
    {
        if (instantiateFruitStole == null)
        {
            instantiateFruitStole = this;
        }
    }

    public void OnSelectButton1()
    {

        Debug.Log("Protect: " + boats[0].ProtectEffect);
        if (boats[0].ProtectEffect == true)
        {
            Debug.Log("Got Protect1");
            
            boats[0].ProtectEffect = false;
        }
        else
        {
            boats[0].Playerpoint -= 2;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint+=2;
                }
            }

        }

    }
    public void OnSelectButton2()
    {
        Debug.Log("Protect: " + boats[0].ProtectEffect);
        if (boats[1].ProtectEffect == true)
        {
            Debug.Log("Got Protect2");
            //boats[1].Playerpoint-=1;
            
            boats[1].ProtectEffect = false;
        }
        else
        {
            //TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Playerpoint++;
            boats[1].Playerpoint -= 2;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint+=2;
                }
            }
        }
    }
    public void OnSelectButton3()
    {
        Debug.Log("Protect: " + boats[0].ProtectEffect);
        if (boats[2].ProtectEffect == true)
        {
            Debug.Log("Got Protect3");
            //boats[2].Playerpoint-=1;
            
            boats[2].ProtectEffect = false;
        }
        else
        {
            //TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Playerpoint++;
            boats[2].Playerpoint -= 2;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint+=2;
                }
            }
        }
    }
    public void OnSelectButton4()
    {
        Debug.Log("Protect: " + boats[0].ProtectEffect);
        if (boats[3].ProtectEffect == true)
        {
            Debug.Log("Got Protect4");
            //boats[3].Playerpoint-=1;
           
            boats[3].ProtectEffect = false;
        }
        else
        {
            //TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Playerpoint++;
            boats[3].Playerpoint -= 2;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint+=2;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint+=2;
                }
            }
        }
    }
}
