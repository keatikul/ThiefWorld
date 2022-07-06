using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    public GameObject dice;
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        dice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        
    }
    public void Roll() 
        {
            dice.SetActive(true);
            DiceNumberTextScript.diceNumber = 0;
            float dirX = Random.Range (0, 100);
            float dirY = Random.Range (0, 100);
            float dirZ = Random.Range (0, 100);
            transform.position = new Vector3 (0, 2, 0);
            transform.rotation = Quaternion.identity;
            rb.AddForce (transform.up * 100);
            rb.AddTorque (dirX, dirY, dirZ);
        }
}
