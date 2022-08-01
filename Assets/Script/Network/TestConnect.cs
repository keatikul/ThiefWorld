using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks
{
    public GameObject loading_;
    private void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        print("Connecting to server..");
        PhotonNetwork.GameVersion = "0.0.1";
        PhotonNetwork.ConnectUsingSettings();
        loading_.SetActive(true);
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to server.");
        PhotonNetwork.JoinLobby();
        loading_.SetActive(false);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server for reason " + cause.ToString());
    }
}
