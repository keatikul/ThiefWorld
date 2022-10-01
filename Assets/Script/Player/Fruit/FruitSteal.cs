using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSteal : MonoBehaviour
{
    public GameObject buttonSelect1;
    public GameObject buttonSelect2;
    public GameObject buttonSelect3;
    public GameObject buttonSelect4;

    public List<Boat> boats = new List<Boat>();
    //public GameObject canvasSteal;
    public static FruitSteal instantiateFruitSteal;
    public bool Onclick;
    public bool Gotprotect = false;
    public int i;
    void Start()
    {
        MakeSingleton();
        //TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
        //CheckTurn();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void MakeSingleton()
    {
        if (instantiateFruitSteal == null)
        {
            instantiateFruitSteal = this;
        }
    }

    public void CheckTurn()
    {
        for (i = 0; i < 4; i++)
        {
            /*if (boats[i].number == 1)
            {
                Debug.Log(boats[i].name);
            }*/
        }
    }

    

    public void OnSelectButton1()
    {
        
        Debug.Log("Protect: " + boats[0].ProtectEffect);
        if (boats[0].ProtectEffect == true)
        {
            Debug.Log("Got Protect1");
            Onclick = true;
            Gotprotect = true;
            boats[0].ProtectEffect = false;
        }else
        {   
            boats[0].Playerpoint -= 1;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint++;
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
            Onclick = true;
            Gotprotect = true;
            boats[1].ProtectEffect = false;
        }
        else
        {
            //TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Playerpoint++;
            boats[1].Playerpoint -= 1;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint++;
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
            Onclick = true;
            Gotprotect = true;
            boats[2].ProtectEffect = false;
        }
        else
        {
            //TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Playerpoint++;
            boats[2].Playerpoint -= 1;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint++;
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
            Onclick = true;
            Gotprotect = true;
            boats[3].ProtectEffect = false;
        }
        else
        {
            //TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Playerpoint++;
            boats[3].Playerpoint -= 1;
            for (i = 0; i < 4; i++)
            {
                if (boats[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true)
                {
                    boats[i].Playerpoint++;
                }
                if (boats[i].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true)
                {
                    boats[i].Playerpoint++;
                }
            }
        }
    }

}
