using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ReadyandStart : MonoBehaviourPunCallbacks
{
    public bool _Start;
    private void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            Debug.Log("Connect this room");
        }
        PhotonNetwork.AutomaticallySyncScene = true;
    }
    public void OnClick_Start() 
    {
        _Start = true;
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel(5);
    }
    
}
