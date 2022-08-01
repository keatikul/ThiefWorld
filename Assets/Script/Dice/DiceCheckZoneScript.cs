using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class DiceCheckZoneScript : MonoBehaviourPunCallbacks
{
    Vector3 diceVelocity;
    public int dicePoint;
    public GameObject dice;
    public static DiceCheckZoneScript instancediceCheck;
    //public DiceScript diceScript;

    void Awake()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
        if (instancediceCheck == null)
        {
            instancediceCheck = this;
        }
    }

    void FixedUpdate()
    {
        diceVelocity = DiceScript.diceVelocity;
        //dicePoint = DiceNumberTextScript.diceNumber;
        if(DiceNumberTextScript.diceNumber > 0)
        {
            //dicePoint = DiceNumberTextScript.diceNumber;
            dice.SetActive(false);
            DiceScript.instance.isRoll = false;//diceScript.isRoll = false;
        }
        if(DiceScript.instance.isRoll == false)
        {
            dicePoint = 0;
        }
    }

    void OnTriggerStay(Collider col) 
    {
        if(diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    DiceNumberTextScript.diceNumber = 6;
                    dicePoint = 6;
                    break;
                case "Side2":
                    DiceNumberTextScript.diceNumber = 5;
                    dicePoint = 5;
                    break;
                case "Side3":
                    DiceNumberTextScript.diceNumber = 4;
                    dicePoint = 4;
                    break;
                case "Side4":
                    DiceNumberTextScript.diceNumber = 3;
                    dicePoint = 3;
                    break;
                case "Side5":
                    DiceNumberTextScript.diceNumber = 2;
                    dicePoint = 2;
                    break;
                case "Side6":
                    DiceNumberTextScript.diceNumber = 1;
                    dicePoint = 1;
                    break;
            }
        }   
    }
}
