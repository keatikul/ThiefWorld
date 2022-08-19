using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWalk : MonoBehaviour
{
    public float speed;
    public float waitTime;
    public float StartWaitTime;
    public Transform[] moveSpot;
    private int randomSpot;
    public Animator anim;
    public bool isMoving;
    
    // Start is called before the first frame update
    void Start()
    {
        waitTime = StartWaitTime;
        randomSpot = Random.Range(0, moveSpot.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot[randomSpot].position, speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, moveSpot[randomSpot].position) < 0.2f) 
        {
            if (waitTime <= 0)
            {
                isMoving = true;
                randomSpot = Random.Range(0, moveSpot.Length);
                transform.LookAt(moveSpot[randomSpot].position);
                waitTime = StartWaitTime;
            }
            else
            {   
                waitTime -= Time.deltaTime;
                isMoving = false;
            }
        }
        if (isMoving == true)
        {
            anim.SetBool("Walk", true);
        }
        if(isMoving == false)
        {
            anim.SetBool("Walk", false);
        }
    }

    
}
