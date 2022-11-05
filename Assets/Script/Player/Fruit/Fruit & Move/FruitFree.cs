using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFree : MonoBehaviour
{
    public GameObject buttonCanvas;
    public List<Boat> boats = new List<Boat>();
    public Timer time;
    public int index;
    public static FruitFree instancefruitFree;

    public void ChangeTime()
    {
        time.timeValue = 7f;
    }

    private void Start()
    {
        MakeSingleton();
    }

    public void MakeSingleton()
    {
        if (instancefruitFree == null)
        {
            instancefruitFree = this;
        }
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
        TurnScriptSinglePlay.instantiateTurnsingle.timeValue = 15f;
        for (int i = 0; i < boats.Count; i++)
        {
            if (boats[i].Bot == false)
            {
                buttonCanvas.SetActive(true);
                if (TurnScriptSinglePlay.instantiateTurnsingle.timeValue == 0)
                {
                    index = Random.Range(1, 7);
                    boats[i].BotMove();
                }
            }
            else
            { 
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && boats[i].number == 1)
                {
                    Debug.Log("1");
                    index = Random.Range(1, 7);
                    boats[i].BotMove();
                    buttonCanvas.SetActive(false);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && boats[i].number == 2)
                {
                    Debug.Log("2");
                    index = Random.Range(1, 7);
                    boats[i].BotMove();
                    buttonCanvas.SetActive(false);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && boats[i].number == 3)
                {
                    Debug.Log("3");
                    index = Random.Range(1, 7);
                    boats[i].BotMove();
                    buttonCanvas.SetActive(false);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && boats[i].number == 4)
                {
                    Debug.Log("4");
                    index = Random.Range(1, 7);
                    boats[i].BotMove();
                    buttonCanvas.SetActive(false);
                }
            }
            
        }
    }

    
}
