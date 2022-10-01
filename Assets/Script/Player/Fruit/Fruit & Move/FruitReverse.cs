using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitReverse : MonoBehaviour
{
    public static FruitReverse instantiateFruitReverse;
    public List<Boat> boats = new List<Boat>();
    void Start()
    {
        MakeSingleton();
        //TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
    }
    void MakeSingleton()
    {
        if (instantiateFruitReverse == null)
        {
            instantiateFruitReverse = this;
        }
    }

    public void OnSelectButton1()
    {
        if (boats[0].ProtectEffect == true)
        {
            Debug.Log("Got Protect1");
            boats[0].ProtectEffect = false;
        }
        else
        {
            boats[0].MoveBack();
        }

    }
    public void OnSelectButton2()
    {
        if (boats[1].ProtectEffect == true)
        {
            Debug.Log("Got Protect2");
            boats[1].ProtectEffect = false;
        }
        else
        {
            boats[1].MoveBack();
        }
    }
    public void OnSelectButton3()
    {
        if (boats[2].ProtectEffect == true)
        {
            Debug.Log("Got Protect3");
            boats[2].ProtectEffect = false;
        }
        else
        {
            boats[2].MoveBack();
        }
    }
    public void OnSelectButton4()
    {
        if (boats[3].ProtectEffect == true)
        {
            Debug.Log("Got Protect4");
            boats[3].ProtectEffect = false;
        }
        else
        {
            boats[3].MoveBack();
        }
    }
}
