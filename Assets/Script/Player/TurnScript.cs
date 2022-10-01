using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class TurnScript : MonoBehaviourPunCallbacks
{
    public GameObject buttonCanvas;
    public bool player1;
    public bool player2;
    public bool player3;
    public bool player4;
    public float timeValue = 7f;
    //public int PhotonPlayer;
    public bool MyfunctionCalled = false;

    public Player Player { get; private set; }
    void Start()
    {
        /*if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            player1 = PhotonNetwork.LocalPlayer.ActorNumber == 1;
            Debug.Log("Player1 here:" + player1);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            player2 = PhotonNetwork.LocalPlayer.ActorNumber == 2;
            Debug.Log("Player2 here:" + player2) ;
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            player3 = PhotonNetwork.LocalPlayer.ActorNumber == 3;
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 4)
        {
            player4 = PhotonNetwork.LocalPlayer.ActorNumber == 4;
        }*/
        //Debug.Log("Start 1st Phase");
        //player1 = true;
        //PhotonNetwork.playerList.Length;
        //CheckPlayerin.instantiateCheck.;
        //Debug.Log("Coun of Player:" + PhotonNetwork.PlayerList.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (MyfunctionCalled == false)
        {
            MyfunctionCalled = true;
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
                player1 = PhotonNetwork.LocalPlayer.ActorNumber == 1;
                player1 = true;
                Debug.Log("Player1 here:" + player1);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            player2 = PhotonNetwork.LocalPlayer.ActorNumber == 2;
            Debug.Log("Player2 here:" + player2) ;
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            player3 = PhotonNetwork.LocalPlayer.ActorNumber == 3;
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 4)
        {
            player4 = PhotonNetwork.LocalPlayer.ActorNumber == 4;
        }
        }

        //Debug.Log("Coun of Player:" + PhotonNetwork.PlayerList.Length);
       
        if (player1 == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                //Debug.Log("Start Counting:" + timeValue);
            }
            else
            {
                Debug.Log("Finish Turn go to next player");
                timeValue = 0;
                
            }
            if (timeValue == 0)
            {
                timeValue = 7f;
                player1 = false;
                player2 = true;
                player3 = false;
                player4 = false;
            }
            
        }
        if (player2 == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                //Debug.Log("Start Counting:" + timeValue);
            }
            else
            {
                Debug.Log("Finish Turn go to next player");
                timeValue = 0;

            }
            if (timeValue == 0)
            {
                timeValue = 7f;
                player1 = false;
                player2 = false;
                player3 = true;
                player4 = false;
            }
        }
        if (player3 == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                //Debug.Log("Start Counting:" + timeValue);
            }
            else
            {
                Debug.Log("Finish Turn go to next player");
                timeValue = 0;

            }
            if (timeValue == 0)
            {
                timeValue = 7f;
                player1 = false;
                player2 = false;
                player3 = false;
                player4 = true;
            }
        }
        if (player4 == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                //Debug.Log("Start Counting:" + timeValue);
            }
            else
            {
                Debug.Log("Finish Turn go to next player");
                timeValue = 0;

            }
            if (timeValue == 0)
            {
                timeValue = 7f;
                player1 = true;
                player2 = false;
                player3 = false;
                player4 = false;
            }
        }
    }
}
