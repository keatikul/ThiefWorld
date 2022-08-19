using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Boat : MonoBehaviour
{
    
    public int Playerpoint = 0;
    public int routePosition;
    public int steps;
    public bool isMoving;
    public static Boat instanceBoatt;
    private Camera cam;
    public int number;


    void Start()
    {
        Debug.Log("Boat Script Start");
        //Debug.Log("Number turn:" + number);
        MakeSingleton();
    }


    void MakeSingleton()
    {
        if (instanceBoatt == null)
        {
            instanceBoatt = this;
        }
    }

    void Update()
    {
        //CharacterMoveWithTurn();
        if (RouteScript.instanceRoute.childNodeList[routePosition].name == "Cube100(Finish)")
        {
            GotoScore();
        }
    }

    public void CharacterMoveWithTurn()
    {
        { 
            steps = PowerUp.instancePowerUp.dicepoint;
            Debug.Log("Dice Roll" + steps);
            StartCoroutine(Move(steps));
            if (routePosition + steps <= RouteScript.instanceRoute.childNodeList.Count)
            {
                StartCoroutine(Move(steps));
            }
            else
            {
                Debug.Log("nani");
            }
        }
            
    }
    


    public void StopMove()
    {
        steps = 0;
    }

    public void GotoScore()
    {

        SceneManager.LoadScene("Score");
    }

    IEnumerator Move(int steps)
    {
        if (isMoving)
        {
            PowerUp.instancePowerUp.dicepoint = 0;
            yield break;
        }
        isMoving = true;


        while (steps > 0)
        {
            Vector3 nextPos = RouteScript.instanceRoute.childNodeList[routePosition + 1].position;
            Debug.Log(RouteScript.instanceRoute.childNodeList[routePosition + 1].name);
            transform.LookAt(nextPos);
            while (MovetoNextNode(nextPos)) { yield return null; }

            yield return new WaitForSeconds(0.1f);
            steps -= 1;
            Debug.Log("" + steps);
            routePosition++;
        }

        isMoving = false;
    }
    bool MovetoNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 1000f * Time.deltaTime));
    }
}

