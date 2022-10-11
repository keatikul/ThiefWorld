using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitProtect : MonoBehaviour
{
    //public bool PlayerStay = false;
    //public static FruitProtect instantiateFruitProtect;
    public Timer time;
    public void ChangeTime()
    {
        time.timeValue = 7f;
    }

    private void Update()
    {
        if (time.timeValue == 0)
        {
            for (int i = 0; i < 4; i++)
            {
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 1)
                {
                    TurnScriptSinglePlay.instantiateTurnsingle.Players[i].ProtectEffect = true;
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 2)
                {
                    TurnScriptSinglePlay.instantiateTurnsingle.Players[i].ProtectEffect = true;
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 3)
                {
                    TurnScriptSinglePlay.instantiateTurnsingle.Players[i].ProtectEffect = true;
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 4)
                {
                    TurnScriptSinglePlay.instantiateTurnsingle.Players[i].ProtectEffect = true;
                }
            }
            time.timeValue = 7f;
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();

        }
    }
    /*void Start()
    {
        MakeSingleton();
        TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
    }
    void MakeSingleton()
    {
        if (instantiateFruitProtect == null)
        {
            instantiateFruitProtect = this;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStay = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStay = false;
        }
    }*/
}
