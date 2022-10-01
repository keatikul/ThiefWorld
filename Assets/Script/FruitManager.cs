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



    //นับเทิน เพื่อให้ Action ที่หยุดเคลื่อนไหวทราบ (อาจจะใช้วิธีการลบเมื่อผ่านเทินตัวเองไป)
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fruit Manager Start");
    }

    // Update is called once per frame
    void Update()
    {
        //Checkfruit();
        ActionFruitSteal();
        ActionFruitFall();
        ActionFruitStole();
        ActionFruitReverse();
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





        /*if (Boat.instanceBoatt.number == 1 && Boat.instanceBoatt != null)
        {
            
            //FruitSteal    
            if (Boat.instanceBoatt.FruitName1 == "apple(Clone)" && Boat.instanceBoatt.PlayerStay == true && Boat.instanceBoatt.isMoving == false)
            {
                canvasSteal.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
                canvasSteal.SetActive(false);
                
        }

        //Protect
            if (Boat.instanceBoatt.FruitName1 == "peanut(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasProtect.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasProtect.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

        //Fall

            if (Boat.instanceBoatt.FruitName1 == "watermelon(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasFall.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasFall.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

        //Stole

            if (Boat.instanceBoatt.FruitName1 == "peach(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStole.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStole.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
            }


        //Stolen

            if (Boat.instanceBoatt.FruitName1 == "pear(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStolen.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStolen.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }
        }

        if (Boat.instanceBoatt.number == 2 && Boat.instanceBoatt != null)
        {
            //FruitSteal    
            if (Boat.instanceBoatt.FruitName2 == "apple(Clone)" && Boat.instanceBoatt.PlayerStay == true && Boat.instanceBoatt.isMoving == false)
            {
                canvasSteal.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
                canvasSteal.SetActive(false);

            }

            //Protect
            if (Boat.instanceBoatt.FruitName2 == "peanut(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasProtect.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasProtect.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

            //Fall

            if (Boat.instanceBoatt.FruitName2 == "watermelon(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasFall.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasFall.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

            //Stole

            if (Boat.instanceBoatt.FruitName2 == "peach(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStole.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStole.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
            }


            //Stolen

            if (Boat.instanceBoatt.FruitName2 == "pear(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStolen.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStolen.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }
        }

        if (Boat.instanceBoatt.number == 3 && Boat.instanceBoatt != null)
        {
            //FruitSteal    
            if (Boat.instanceBoatt.FruitName3 == "apple(Clone)" && Boat.instanceBoatt.PlayerStay == true && Boat.instanceBoatt.isMoving == false)
            {
                canvasSteal.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
                canvasSteal.SetActive(false);

            }

            //Protect
            if (Boat.instanceBoatt.FruitName3 == "peanut(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasProtect.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasProtect.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

            //Fall

            if (Boat.instanceBoatt.FruitName3 == "watermelon(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasFall.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasFall.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

            //Stole

            if (Boat.instanceBoatt.FruitName3 == "peach(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStole.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStole.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
            }


            //Stolen

            if (Boat.instanceBoatt.FruitName3 == "pear(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStolen.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStolen.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }
        }

        if (Boat.instanceBoatt.number == 4 && Boat.instanceBoatt != null)
        {
            //FruitSteal    
            if (Boat.instanceBoatt.FruitName4 == "apple(Clone)" && Boat.instanceBoatt.PlayerStay == true && Boat.instanceBoatt.isMoving == false)
            {
                canvasSteal.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
                canvasSteal.SetActive(false);

            }

            //Protect
            if (Boat.instanceBoatt.FruitName4 == "peanut(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasProtect.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasProtect.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

            //Fall

            if (Boat.instanceBoatt.FruitName4 == "watermelon(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasFall.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasFall.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }

            //Stole

            if (Boat.instanceBoatt.FruitName4 == "peach(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStole.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStole.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }
            }


            //Stolen

            if (Boat.instanceBoatt.FruitName4 == "pear(Clone)" && Boat.instanceBoatt.PlayerStay == true)
            {
                //Debug.Log("Working");
                canvasStolen.SetActive(true);
                //Debug.Log("Working");
            }
            if (Boat.instanceBoatt.PlayerStay == false)
            {
                canvasStolen.SetActive(false);
                if (Timer.instantiateTimer != null)
                {
                    Timer.instantiateTimer.timeValue = 7;
                }

            }
        }

        {
            /*if(FruitSteal.instantiateFruitSteal.PlayerStay == false)
                    {
                        canvasSteal.SetActive(false);
                    }
                    //FruitProtect
                    if (FruitProtect.instantiateFruitProtect.PlayerStay == true && BoatScript.instanceBoat.isMoving == false)
                    {
                        canvasProtect.SetActive(true);
                        //Debug.Log("Working");
                    }
                    else
                    {
                        //Debug.Log("Protect Not Working");
                    }
                    if (FruitProtect.instantiateFruitProtect.PlayerStay == false)
                    {
                        canvasProtect.SetActive(false);
                    }
                    //FruitFall
                    if (FruitFall.instantiateFruitFall.PlayerStay == true && BoatScript.instanceBoat.isMoving == false)
                    {
                        canvasFall.SetActive(true);
                        //Debug.Log("Working");
                    }
                    else
                    {
                        //Debug.Log("Fall Not Working");
                    }
                    if (FruitFall.instantiateFruitFall.PlayerStay == false)
                    {
                        canvasFall.SetActive(false);
                    }
                    //FruitStole
                    if (FruitStole.instantiateFruitStole.PlayerStay == true && BoatScript.instanceBoat.isMoving == false)
                    {
                        canvasStole.SetActive(true);
                        //Debug.Log("Working");
                    }
                    else
                    {
                        //Debug.Log("Stole Not Working");
                    }
                    if (FruitStole.instantiateFruitStole.PlayerStay == false)
                    {
                        canvasStole.SetActive(false);
                    }
                    //FruitStolen
                    if (FruitStolen.instantiateFruitStolen.PlayerStay == true && BoatScript.instanceBoat.isMoving == false)
                    {
                        canvasStolen.SetActive(true);
                        //Debug.Log("Working");
                    }
                    else
                    {
                        //Debug.Log("Stolen Not Working");
                    }
                    if (FruitStolen.instantiateFruitStolen.PlayerStay == false)
                    {
                        canvasStolen.SetActive(false);
                    }
        }*/

    }

    public void OnclickActionSteal()
    {
        Boat.instanceBoatt.PlayerStay = false;
        canvasSteal.SetActive(false);
        Timer.instantiateTimer.timeValue = 7;
        Debug.Log("Close canvas click");
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
            btsteal1.SetActive(false);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(false);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(false);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(false);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(false);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(false);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(false);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(false);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(false);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(false);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(false);
            btsteal3.SetActive(true);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(false);
            btsteal4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "apple(Clone)")
        {
            btsteal1.SetActive(true);
            btsteal2.SetActive(true);
            btsteal3.SetActive(true);
            btsteal4.SetActive(false);
        }
        //}

    }

    public void ActionFruitFall()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(false);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(false);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(false);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(false);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(false);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(false);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(false);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(false);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(false);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(false);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(false);
            btfall3.SetActive(true);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(false);
            btfall4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "watermelon(Clone)")
        {
            btfall1.SetActive(true);
            btfall2.SetActive(true);
            btfall3.SetActive(true);
            btfall4.SetActive(false);
        }
    }

    public void ActionFruitStole()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(false);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(false);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(false);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(false);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(false);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(false);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(false);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(false);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(false);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(false);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(false);
            btstole3.SetActive(true);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(false);
            btstole4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "peach(Clone)")
        {
            btstole1.SetActive(true);
            btstole2.SetActive(true);
            btstole3.SetActive(true);
            btstole4.SetActive(false);
        }
    }

    public void ActionFruitReverse()
    {
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(false);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(false);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(true);
            btreverse3.SetActive(false);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn3 == false && checkTurn4 == false) 
        //{ 
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(false);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(false);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse3.SetActive(false);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 2 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn4 == false) 
        //{        
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(false);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(false);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(true);
            btreverse3.SetActive(false);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 3 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(false);
        }
        //}

        //if (checkTurn1 == false && checkTurn2 == false && checkTurn3 == false) 
        //{
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[0].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(false);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[1].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(false);
            btreverse3.SetActive(true);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[2].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(true);
            btreverse3.SetActive(false);
            btreverse4.SetActive(true);
        }
        if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].number == 4 && TurnScriptSinglePlay.instantiateTurnsingle.Players[3].FruitName1 == "banana(Clone)")
        {
            btreverse1.SetActive(true);
            btreverse2.SetActive(true);
            btreverse3.SetActive(true);
            btreverse4.SetActive(false);
        }
    }
}
