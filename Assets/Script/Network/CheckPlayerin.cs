using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CheckPlayerin : MonoBehaviourPunCallbacks
{
    public int player = 0;

    public static CheckPlayerin instantiateCheck;

    private void Start()
    {
        MakeSingleton();
        PhotonNetwork.AutomaticallySyncScene = true;
    }
    void MakeSingleton()
    {
        if (instantiateCheck == null)
        {
            instantiateCheck = this;
        }
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        if (newPlayer.ActorNumber > 1)
        {
            player = newPlayer.ActorNumber;
        }
        Debug.Log($"player id: {newPlayer.ActorNumber}");
        Debug.Log("Player Enter Room");
        base.OnPlayerEnteredRoom(newPlayer);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log("Player Left.");
        base.OnPlayerLeftRoom(otherPlayer);

    }
}
