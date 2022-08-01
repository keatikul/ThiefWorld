using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ReadyandStart : MonoBehaviourPunCallbacks
{
    public bool _Start;
    public static ReadyandStart instantiateRaS;
    private void Start()
    {
        MakeSingleton();
        if (PhotonNetwork.IsConnected)
        {
            Debug.Log("Connect this room");
        }
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    void MakeSingleton()
    {
        if (instantiateRaS == null)
        {
            instantiateRaS = this;
        }
    }
    public void OnClick_Start() 
    {
        _Start = true;
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel(5);
    }
    
}
