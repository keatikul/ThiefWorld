using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    public GameObject dice;
    public float holddownStarttime;
    bool buttonHoldDown = false;
    public float power;
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        dice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;
        if (buttonHoldDown == true)
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
        }
        
    }


    public void HoldButton()
    {
        buttonHoldDown = true;
    }

    public void ReleaseButton()
    {
        buttonHoldDown = false;
        Roll();
    }



    public void Roll() 
        {
            dice.SetActive(true);
            holddownStarttime = Time.time;
            DiceNumberTextScript.diceNumber = 0;
            float dirX = Random.Range (0, 500);
            float dirY = Random.Range (0, 500);
            float dirZ = Random.Range (0, 500);
            transform.position = new Vector3 (0, 3, 0);
            transform.rotation = Quaternion.identity;
            rb.AddForce (transform.up * power);
            rb.AddTorque (dirX, dirY, dirZ);
        }
}
