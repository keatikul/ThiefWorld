using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class BoatScript : MonoBehaviourPunCallbacks
{

    public PhotonView photonView;

    int routePosition;

    public int steps;

    bool isMoving;

    public static BoatScript instanceBoat;


    public static GameObject LocalPlayerInstance;
    private Camera cam;


    /*public GameObject route;
    public GameObject DiceCheckZone;
    public GameObject Dice;*/


    void Awake()
    {
        photonView = GetComponent<PhotonView>();
        PhotonNetwork.AutomaticallySyncScene = true;
        MakeSingleton();
        //diceCheck = GameObject.Find("DiceCheckZone").GetComponent<DiceCheckZoneScript>();
        //diceSc = GameObject.Find("Dice").GetComponent<DiceScript>();
        if (photonView.IsMine)
        {
            BoatScript.LocalPlayerInstance = this.gameObject;
        }
        DontDestroyOnLoad(this.gameObject);
        if (!photonView.IsMine)
        {
            //Destroy(cam);
            cam.enabled = false;
        }
    }


    void MakeSingleton()
    {
        if (instanceBoat == null)
        {
            instanceBoat = this;
        }
    }

    void Update()
    {
        //diceSc = GameObject.Find("Dice").GetComponent<DiceScript>();
        //steps = diceCheck.dicePoint;
        if (PowerUp.instancePowerUp.isRoll == true && !isMoving)
        //if(Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            steps = PowerUp.instancePowerUp.dicepoint;
            //steps = Random.Range(1,7);
            //steps = 6;
            Debug.Log("Dice Roll" + steps);
            //Debug.Log("Routeposition"+routePosition+steps);
            StartCoroutine(Move());
            if (routePosition + steps <= RouteScript.instanceRoute.childNodeList.Count/*currentRoute.childNodeList.Count*/)
            {
                StartCoroutine(Move());
                //PowerUp.instancePowerUp.moveBoat = false;
                //Debug.Log(""Move);
            }
            else
            {
                Debug.Log("nani");
            }

        }

        if (RouteScript.instanceRoute.childNodeList[routePosition].name == "Cube100(Finish)")
        {
            GotoScore();
            OnLeftRoom();
        }
    }

    public override void OnLeftRoom()
    {
        NetworkSpawnPlayer.instantiateNWS.OnLeftRoom();
    }
    public void GotoScore()
    {

        PhotonNetwork.LoadLevel(6);
    }

        IEnumerator Move()
        {
            if (isMoving)
            {
                PowerUp.instancePowerUp.dicepoint = 0;
                yield break;
            }
            isMoving = true;


            while (steps > 0)
            {
                //routePosition++;
                //routePosition %= currentRoute.childNodeList.Count;

                Vector3 nextPos = RouteScript.instanceRoute.childNodeList[routePosition + 1].position;
                Debug.Log(RouteScript.instanceRoute.childNodeList[routePosition + 1].name);
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

