using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public GameObject canvasSteal;
    public GameObject canvasProtect;
    public GameObject canvasFall;
    public GameObject canvasStole;
    public GameObject canvasStolen;


    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;


    //Steal Button
    public GameObject btsteal1;
    public GameObject btsteal2;
    public GameObject btsteal3;
    public GameObject btsteal4;


    //Fall Button
    public GameObject btfall1;
    public GameObject btfall2;
    public GameObject btfall3;
    public GameObject btfall4;

    //Stole Button
    public GameObject btstole1;
    public GameObject btstole2;
    public GameObject btstole3;
    public GameObject btstole4;

    //Reverse Button
    public GameObject btreverse1;
    public GameObject btreverse2;
    public GameObject btreverse3;
    public GameObject btreverse4;

    public static FruitManager instanceFruitmanager;

    public GameObject OkButtonSiren;
    public GameObject OkButtonFreeze;
    public GameObject OkButtonFree;
    public GameObject OkButtonTime;
    public GameObject OkButtonProtect;
    public GameObject OkButtonStolen;


    //นับเทิน เพื่อให้ Action ที่หยุดเคลื่อนไหวทราบ (อาจจะใช้วิธีการลบเมื่อผ่านเทินตัวเองไป)
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fruit Manager Start");
        MakeSingleton();
    }

    void MakeSingleton()
    {
        if (instanceFruitmanager == null)
        {
            instanceFruitmanager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Checkfruit();
        ActionFruitSteal();
        ActionFruitFall();
        ActionFruitStole();
        ActionFruitReverse();
        ActionSiren();
        ActionFreeze();
        ActionFree();
        ActionTime();
        ActionProtect();
        ActionStolen();
    }
    public void Checkfruit()
    {
        //player on fruit
        //check fruit = true
        //Canvas is opne
        //time count
        //player use action fruit
        //after finish End turn
        //player left fruit
        //Canvas is close



        //save data fruit to route
        //check from route who have what?
        //collider use 1 of this Box or Mesh
    }

    public void OnclickActionSteal()
    {
        canvasSteal.SetActive(false);
        Timer.instantiateTimer.timeValue = 7;
        Debug.Log("Close canvas click");
    }

    public void ActionStolen()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "pear(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonStolen.SetActive(true);
            }
            else
            {
                OkButtonStolen.SetActive(false);
            }
        }
    }

    public void ActionProtect()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peanut(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonProtect.SetActive(true);
            }
            else
            {
                OkButtonProtect.SetActive(false);
            }
        }
    }

    public void ActionTime()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "cherries(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonTime.SetActive(true);
            }
            else
            {
                OkButtonTime.SetActive(false);
            }
        }
    }

    public void ActionFree()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "strawberry(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFree.SetActive(true);
            }
            else
            {
                OkButtonFree.SetActive(false);
            }
        }
    }

    public void ActionFreeze()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "lemon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonFreeze.SetActive(true);
            }
            else
            {
                OkButtonFreeze.SetActive(false);
            }
        }
    }

    public void ActionSiren()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }

        //----------------------------------------------------------------------

        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "avocado(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                OkButtonSiren.SetActive(true);
            }
            else
            {
                OkButtonSiren.SetActive(false);
            }
        }
    }

    public void ActionFruitSteal()
    {
        //Steal
        //Player Click Whoever -1 point
        //Player in turn +1 point
        //After Player Click EndTurn
        //if (checkTurn2 == false && checkTurn3 == false && checkTurn4 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btsteal2.SetActive(false);
                btsteal1.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btsteal3.SetActive(false);
                btsteal2.SetActive(true);
                btsteal1.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btsteal4.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal1.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btsteal2.SetActive(false);
                btsteal1.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btsteal3.SetActive(false);
                btsteal2.SetActive(true);
                btsteal1.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btsteal4.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal1.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btsteal2.SetActive(false);
                btsteal1.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btsteal3.SetActive(false);
                btsteal2.SetActive(true);
                btsteal1.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btsteal4.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal1.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btsteal2.SetActive(false);
                btsteal1.SetActive(true);
                btsteal3.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btsteal3.SetActive(false);
                btsteal2.SetActive(true);
                btsteal1.SetActive(true);
                btsteal4.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btsteal4.SetActive(false);
                btsteal2.SetActive(true);
                btsteal3.SetActive(true);
                btsteal1.SetActive(true);
            }
            else
            {
                btsteal1.SetActive(false);
                btsteal2.SetActive(false);
                btsteal3.SetActive(false);
                btsteal4.SetActive(false);
            }
        }
        //}

    }

    public void ActionFruitFall()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btfall1.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btfall2.SetActive(false);
                btfall1.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btfall3.SetActive(false);
                btfall2.SetActive(true);
                btfall1.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btfall4.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall1.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btfall1.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btfall2.SetActive(false);
                btfall1.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btfall3.SetActive(false);
                btfall2.SetActive(true);
                btfall1.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btfall4.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall1.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btfall1.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btfall2.SetActive(false);
                btfall1.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btfall3.SetActive(false);
                btfall2.SetActive(true);
                btfall1.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btfall4.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall1.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btfall1.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btfall2.SetActive(false);
                btfall1.SetActive(true);
                btfall3.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btfall3.SetActive(false);
                btfall2.SetActive(true);
                btfall1.SetActive(true);
                btfall4.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btfall4.SetActive(false);
                btfall2.SetActive(true);
                btfall3.SetActive(true);
                btfall1.SetActive(true);
            }
            else
            {
                btfall1.SetActive(false);
                btfall2.SetActive(false);
                btfall3.SetActive(false);
                btfall4.SetActive(false);
            }
        }
    }

    public void ActionFruitStole()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btstole1.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btstole2.SetActive(false);
                btstole1.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btstole3.SetActive(false);
                btstole2.SetActive(true);
                btstole1.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btstole4.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole1.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btstole1.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btstole2.SetActive(false);
                btstole1.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btstole3.SetActive(false);
                btstole2.SetActive(true);
                btstole1.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btstole4.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole1.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btstole1.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btstole2.SetActive(false);
                btstole1.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btstole3.SetActive(false);
                btstole2.SetActive(true);
                btstole1.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btstole4.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole1.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btstole1.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btstole2.SetActive(false);
                btstole1.SetActive(true);
                btstole3.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btstole3.SetActive(false);
                btstole2.SetActive(true);
                btstole1.SetActive(true);
                btstole4.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btstole4.SetActive(false);
                btstole2.SetActive(true);
                btstole3.SetActive(true);
                btstole1.SetActive(true);
            }
            else
            {
                btstole1.SetActive(false);
                btstole2.SetActive(false);
                btstole3.SetActive(false);
                btstole4.SetActive(false);
            }
        }
    }

    public void ActionFruitReverse()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btreverse2.SetActive(false);
                btreverse1.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btreverse3.SetActive(false);
                btreverse2.SetActive(true);
                btreverse1.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btreverse4.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse1.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btreverse2.SetActive(false);
                btreverse1.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btreverse3.SetActive(false);
                btreverse2.SetActive(true);
                btreverse1.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btreverse4.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse1.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btreverse2.SetActive(false);
                btreverse1.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btreverse3.SetActive(false);
                btreverse2.SetActive(true);
                btreverse1.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btreverse4.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse1.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[0].Bot == false)
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot == false)
            {
                btreverse2.SetActive(false);
                btreverse1.SetActive(true);
                btreverse3.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot == false)
            {
                btreverse3.SetActive(false);
                btreverse2.SetActive(true);
                btreverse1.SetActive(true);
                btreverse4.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot == false)
            {
                btreverse4.SetActive(false);
                btreverse2.SetActive(true);
                btreverse3.SetActive(true);
                btreverse1.SetActive(true);
            }
            else
            {
                btreverse1.SetActive(false);
                btreverse2.SetActive(false);
                btreverse3.SetActive(false);
                btreverse4.SetActive(false);
            }
        }
    }
}
