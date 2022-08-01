using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class DiceScript : MonoBehaviourPunCallbacks
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    public GameObject dice;
    //public RollPower rollPW;
    //public float holddownStarttime;
    //bool buttonHoldDown = false;
    //public float power;
    public bool isRoll = false;
    public static DiceScript instance;
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        //dice.SetActive(false);
        MakeSingleton();
    }

    void MakeSingleton() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //diceVelocity = rb.velocity;
        /*if (buttonHoldDown == true)
        {
            holddownStarttime += Time.deltaTime;
        }
        if(holddownStarttime <= 2)
        {
            power = 500;
        }else
        {
            power = 30;
        }

        if(buttonHoldDown == false)
        {
            holddownStarttime = 0;
        }*/

        
    }



    /*public void HoldButton()
    {
        buttonHoldDown = true;
    }

    public void ReleaseButton()
    {
        buttonHoldDown = false;
        Roll();
        //isRoll = true;
    }*/



    public void Roll() 
        {
            dice.SetActive(true);
            RollPower.instanceRollPw.holddownStarttime = Time.time;
            DiceNumberTextScript.diceNumber = 0;
            float dirX = Random.Range (0, 500);
            float dirY = Random.Range (0, 500);
            float dirZ = Random.Range (0, 500);
            transform.position = new Vector3 (0, 288, 0);
            transform.rotation = Quaternion.identity;
            rb.AddForce (transform.up * RollPower.instanceRollPw.power);
            rb.AddTorque (dirX, dirY, dirZ);
            isRoll = true;
        }
}
