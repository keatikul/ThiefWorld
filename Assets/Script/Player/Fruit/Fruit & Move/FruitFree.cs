using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFree : MonoBehaviour
{
    public GameObject buttonCanvas;
    public List<Boat> boats = new List<Boat>();
    public Timer time;
    public void ChangeTime()
    {
        time.timeValue = 7f;
    }

    private void Update()
    {
        if (time.timeValue == 0)
        {
            FreeEffect();
            time.timeValue = 7f;
        }
        
    }
    public void FreeEffect()
    {
        buttonCanvas.SetActive(true);
        TurnScriptSinglePlay.instantiateTurnsingle.timeValue = 15f;
        for (int i = 0; i < boats.Count; i++)
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && boats[i].number == 1 && boats[i].Bot == true)
            {
                boats[i].BotMove();
                buttonCanvas.SetActive(false);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && boats[i].number == 2 && boats[i].Bot == true)
            {
                boats[i].BotMove();
                buttonCanvas.SetActive(false);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && boats[i].number == 3 && boats[i].Bot == true)
            {
                boats[i].BotMove();
                buttonCanvas.SetActive(false);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && boats[i].number == 4 && boats[i].Bot == true)
            {
                boats[i].BotMove();
                buttonCanvas.SetActive(false);
            }
        }
    }

    
}
