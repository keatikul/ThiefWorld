using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BoatScript : MonoBehaviourPunCallbacks
{
    public RouteScript currentRoute;

    public DiceCheckZoneScript diceCheck;

    public DiceScript diceSc;

    public PhotonView photonView;

    int routePosition;

    public int steps;

    bool isMoving;

    /*public GameObject route;
    public GameObject DiceCheckZone;
    public GameObject Dice;*/
    

    void Start() {
        photonView = GetComponent<PhotonView>();
        currentRoute = GameObject.Find("Route").GetComponent<RouteScript>();
        diceCheck = GameObject.Find("DiceCheckZone").GetComponent<DiceCheckZoneScript>();
        //diceSc = GameObject.Find("Dice").GetComponent<DiceScript>();
    }   

    void Update() 
    {
        diceSc = GameObject.Find("Dice").GetComponent<DiceScript>();
        //steps = diceCheck.dicePoint;
        if(diceSc.isRoll == true && !isMoving)
        //if(Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            steps = diceCheck.dicePoint;
            //steps = Random.Range(1,7);
            //steps = 6;
            Debug.Log("Dice Roll" + steps);
            Debug.Log("Routeposition"+routePosition+steps);
            StartCoroutine(Move());
            if(routePosition+steps <= currentRoute.childNodeList.Count)
            {
                StartCoroutine(Move());
                //Debug.Log(""Move);
            }
            else
            {
                Debug.Log("nani");
            }
        }
    }

    IEnumerator Move()
    {
        if(isMoving)
        {
            yield break;
        }
        isMoving = true;

        while(steps > 0)
        {
            //routePosition++;
            //routePosition %= currentRoute.childNodeList.Count;

            Vector3 nextPos = currentRoute.childNodeList[routePosition+1].position;
            while(MovetoNextNode(nextPos)){yield return null;}

            yield return new WaitForSeconds(0.1f);
            steps -= 1;
            Debug.Log(""+steps);
            routePosition++;
        }

        isMoving = false;
    }

    bool MovetoNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 8f * Time.deltaTime));
    }
}
