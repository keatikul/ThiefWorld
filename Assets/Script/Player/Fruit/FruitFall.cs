using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFall : MonoBehaviour
{
    public static FruitFall instantiateFruitFall;
    public List<Boat> boats = new List<Boat>();
    public List<Boat> addboats = new List<Boat>();
    public List<int> n_boats = new List<int>();
    public int select;
    public Timer time;
    public int numbernboat = 3;
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
        if (instantiateFruitFall == null)
        {
            instantiateFruitFall = this;
        }
    }
    public void Checkplayer()
    {

        for (int i = 0; i < boats.Count; i++)
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && addboats.Count < 3)
            {
                if (boats[i].number != 1)
                {
                    addboats.Add(boats[i]);
                }
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && addboats.Count < 3)
            {
                if (boats[i].number != 2)
                {
                    addboats.Add(boats[i]);
                }
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && addboats.Count < 3)
            {
                if (boats[i].number != 3)
                {
                    addboats.Add(boats[i]);
                }
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && addboats.Count < 3)
            {
                if (boats[i].number != 4)
                {
                    addboats.Add(boats[i]);
                }
            }
        }
    }

    private void Update()
    {

        if (time.timeValue == 0)
        {
            Checkplayer();
            for (int i = 0; i < addboats.Count; i++)
            {
                Debug.Log("Add n_boat");
                n_boats.Add(addboats[i].Playerpoint);
            }
            n_boats.Sort();
            for (int j = 0; j < addboats.Count; j++)
            {
                if (addboats[j].Playerpoint == n_boats[2])
                {
                    select = addboats[j].numberboat;
                }
            }
            Debug.Log("Select: " + select);
            if (select == 1)
            {
                OnSelectButton1();
                TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                select = 0;
            }
            if (select == 2)
            {
                OnSelectButton2();
                TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                select = 0;
            }
            if (select == 3)
            {
                OnSelectButton3();
                TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                select = 0;
            }
            if (select == 4)
            {
                OnSelectButton4();
                TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
                select = 0;
            }

            n_boats.Clear();
            addboats.Clear();
            time.timeValue = 7f;

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
            boats[0].Playerpoint -= 2;
            
        }

    }
    public void OnSelectButton2()
    {
        if (boats[1].ProtectEffect == true)
        {
            Debug.Log("Got Protect2");
            //boats[1].Playerpoint-=1;
            boats[1].ProtectEffect = false;
        }
        else
        {
            boats[1].Playerpoint -= 2;
            
        }
    }
    public void OnSelectButton3()
    {
        if (boats[2].ProtectEffect == true)
        {
            Debug.Log("Got Protect3");
            //boats[2].Playerpoint-=1;

            boats[2].ProtectEffect = false;
        }
        else
        {
            boats[2].Playerpoint -= 2;
            
        }
    }
    public void OnSelectButton4()
    {
        if (boats[3].ProtectEffect == true)
        {
            Debug.Log("Got Protect4");
            //boats[3].Playerpoint-=1;
     
            boats[3].ProtectEffect = false;
        }
        else
        {
            boats[3].Playerpoint -= 2;
            
        }
    }
}
